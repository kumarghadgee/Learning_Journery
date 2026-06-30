package com.healthcare.tester;

import java.util.Scanner;

import org.hibernate.SessionFactory;

import com.healthcare.dao.ProductDaoImpl;
import com.healthcare.dao.ProductDao;
import com.healthcare.utils.HibernateUtils;

public class ProductByRange {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try (SessionFactory sf = HibernateUtils.getSessionFactory();
				Scanner sc = new Scanner(System.in)) {
			// create user dao instance (depcy)
			ProductDao productDao = new ProductDaoImpl();
			System.out.println("Enter Minimum and Maximum Price : ");
			productDao.getAllProductsByRange(sc.nextInt(), sc.nextInt()).forEach(System.out::println);
		} // JVM - sf.close() => DBCP cleaned up -connections closing
		catch (Exception e) {
			e.printStackTrace();
		}
	}

}
