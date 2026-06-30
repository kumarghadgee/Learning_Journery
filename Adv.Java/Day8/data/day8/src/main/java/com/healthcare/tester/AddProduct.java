package com.healthcare.tester;

import java.time.LocalDate;
import java.util.Scanner;

import org.hibernate.SessionFactory;

import com.healthcare.dao.ProductDao;
import com.healthcare.dao.ProductDaoImpl;
import com.healthcare.entities.Product;
import com.healthcare.entities.ProductCategory;
import com.healthcare.entities.User;
import com.healthcare.entities.UserRole;
import com.healthcare.utils.HibernateUtils;

public class AddProduct {

	public static void main(String[] args) {
		try (SessionFactory sf = HibernateUtils.getSessionFactory();
				Scanner sc=new Scanner(System.in)) {
			// create user dao instance (depcy)
			ProductDao productDao = new ProductDaoImpl();
			System.out.println(
					"Enter user details - productName,  productDescription,  price,  quantity,  category");
			Product product = new Product(sc.next(), sc.next(), sc.nextDouble(), sc.nextInt(), ProductCategory.valueOf(sc.next().toUpperCase()));
			System.out.println("Reg staus - "+productDao.addProduct(product));
		} // JVM - sf.close() => DBCP cleaned up -connections closing
		catch (Exception e) {
			e.printStackTrace();
		}

	}

}
