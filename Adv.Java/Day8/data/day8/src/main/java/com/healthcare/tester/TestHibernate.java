package com.healthcare.tester;

import org.hibernate.SessionFactory;

import com.healthcare.utils.HibernateUtils;

public class TestHibernate {

	public static void main(String[] args) {
		try (SessionFactory sf = HibernateUtils.getSessionFactory()) {
			System.out.println("Hibernate up & running....");
		} //JVM - sf.close() => DBCP cleaned up -connections closing 
		catch (Exception e) {
			e.printStackTrace();
		}

	}

}
