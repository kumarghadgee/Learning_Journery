package com.healthcare.utils;
import org.hibernate.*;
import org.hibernate.cfg.Configuration;

public class HibernateUtils {
	private static SessionFactory sessionFactory;
	static {
		System.out.println("in static block");
		/*
		 * To build SF(SessionFactory)
		 * 1. Create Configuration instance
		 *   - using default constructor
		 *  2. Configure it
		 *    - to load config from hibernate.cfg.xml
		 *  3. Build DessionFactory from config object.
		 */
		sessionFactory=new Configuration() //empty config
		.configure() //loads all props & mappings from config file
		.buildSessionFactory();
	}
	public static SessionFactory getSessionFactory() {
		return sessionFactory;
	}
	

}
