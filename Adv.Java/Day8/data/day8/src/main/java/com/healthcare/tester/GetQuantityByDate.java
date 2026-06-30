package com.healthcare.tester;

import java.time.LocalDate;
import java.util.Scanner;

import org.hibernate.SessionFactory;

import com.healthcare.dao.ProductDao;
import com.healthcare.dao.ProductDaoImpl;
import com.healthcare.entities.ProductCategory;
import com.healthcare.utils.HibernateUtils;

public class GetQuantityByDate {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try (SessionFactory sf = HibernateUtils.getSessionFactory();
				Scanner sc = new Scanner(System.in)) {
			// create user dao instance (depcy)
			ProductDao productDao = new ProductDaoImpl();
			System.out.println("Enter the Manufacture Date and Category: ");
			productDao.allQuantityList(LocalDate.parse(sc.next()), ProductCategory.valueOf(sc.next().toUpperCase())).forEach(System.out::println);
		} // JVM - sf.close() => DBCP cleaned up -connections closing
		catch (Exception e) {
			e.printStackTrace();
		}
	}

}
