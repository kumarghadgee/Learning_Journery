package com.healthcare.tester;

import java.time.LocalDate;
import java.util.Scanner;

import org.hibernate.SessionFactory;

import com.healthcare.dao.ProductDao;
import com.healthcare.dao.ProductDaoImpl;
import com.healthcare.entities.ProductCategory;
import com.healthcare.utils.HibernateUtils;

public class ChangePriceByProdName {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try (SessionFactory sf = HibernateUtils.getSessionFactory();
				Scanner sc = new Scanner(System.in)) {
			// create user dao instance (depcy)
			ProductDao productDao = new ProductDaoImpl();
			System.out.println("Enter the Name Of Product and Price : ");
			productDao.changePrice(sc.nextLine(), sc.nextDouble());
		} // JVM - sf.close() => DBCP cleaned up -connections closing
		catch (Exception e) {
			e.printStackTrace();
		}
	}

}
