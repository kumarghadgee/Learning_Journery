package com.healthcare.tester;

import java.time.LocalDate;
import java.util.Scanner;

import org.hibernate.SessionFactory;

import com.healthcare.dao.UserDao;
import com.healthcare.dao.UserDaoImpl;
import com.healthcare.entities.User;
import com.healthcare.entities.UserRole;
import com.healthcare.utils.HibernateUtils;

public class RegisterNewUser {

	public static void main(String[] args) {
		try (SessionFactory sf = HibernateUtils.getSessionFactory();
				Scanner sc=new Scanner(System.in)) {
			// create user dao instance (depcy)
			UserDao userDao = new UserDaoImpl();
			System.out.println(
					"Enter user details - firstName,  lastName,  email,  password,  dob,  phone,	 userRole,  regAmount");
			User user=new User(sc.next(), sc.next(), sc.next(), sc.next(), LocalDate.parse(sc.next()), sc.next(), UserRole.valueOf(sc.next().toUpperCase()), sc.nextInt());
			System.out.println("Reg staus - "+userDao.registerUser(user));
		} // JVM - sf.close() => DBCP cleaned up -connections closing
		catch (Exception e) {
			e.printStackTrace();
		}

	}

}
