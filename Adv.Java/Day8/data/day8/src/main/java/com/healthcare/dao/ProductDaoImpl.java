package com.healthcare.dao;

import java.time.LocalDate;
import java.util.List;

import org.hibernate.Session;
import org.hibernate.Transaction;

import com.healthcare.entities.Product;
import com.healthcare.entities.ProductCategory;
import com.healthcare.utils.HibernateUtils;

public class ProductDaoImpl implements ProductDao {

	@Override
	public String addProduct(Product newProduct) {
		// TODO Auto-generated method stub
		String message = "adding Product failed";
		Session session = HibernateUtils.getSessionFactory().getCurrentSession();
		Transaction tx = session.beginTransaction();
		try {
			session.persist(newProduct);
			tx.commit();
			message = "New Product added with ID"+newProduct.getProductId();
		} catch (RuntimeException e) {
			// TODO: handle exception
			if(tx != null) {
				tx.rollback();
			}
			throw e;
		}
		return message;
	}
	
	@Override
	public List<Product> getAllProductsByRange(Integer minPrice,Integer maxPrice){
//		String message = "Got all Products Between Min and Max Price";
		List<Product> product = null;
		String jpql = "select p from Product p where p.price Between :min and :max ";
		Session session = HibernateUtils.getSessionFactory().getCurrentSession();
		Transaction tx = session.beginTransaction();
		try 
		{
			product =session.createQuery(jpql,Product.class).setParameter("min", minPrice).setParameter("max",maxPrice).getResultList();
			tx.commit();
		}
		catch(RuntimeException e)
		{
			if(tx != null)
			{
				tx.rollback();
			}
			throw e;
		}
		return product;
	}
	
	@Override
	public List<Integer> allQuantityList(LocalDate date,ProductCategory category){
		List<Integer> quant = null;
		String jpql = "select p.quantity from Product p where p.manufactureDate < :date and p.productCategory = :category";
		Session session = HibernateUtils.getSessionFactory().getCurrentSession();
		Transaction tx = session.beginTransaction();
		try 
		{
			quant = session.createQuery(jpql,Integer.class).setParameter("date",date).setParameter("category", category).getResultList();
			tx.commit();
		}
		catch(RuntimeException e)
		{
			if(tx != null)
			{
				tx.rollback();
			}
			throw e;
		}
		return quant;
	}
	
	@Override
	public String changePrice(String name,Double price) {
		Product prod = null;
		String jpql = "select p from Product p where p.productName =:name";
		Session session = HibernateUtils.getSessionFactory().getCurrentSession();
		Transaction tx = session.beginTransaction();
		try
		{
			prod = session.createQuery(jpql,Product.class).setParameter("name",name).getSingleResult();
			prod.setPrice(price);
			tx.commit();
		}
		catch(RuntimeException e)
		{
			if(tx != null)
			{
				tx.rollback();
			}
			throw e;
		}
		return "Price of an "+ name + "is changed";
	}

}
