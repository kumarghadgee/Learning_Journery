package com.healthcare.dao;

import com.healthcare.entities.User;
import com.healthcare.utils.HibernateUtils;

import org.hibernate.*;

public class UserDaoImpl implements UserDao {

	@Override
	public String registerUser(User newUser) {
		String message="User reg failed !!!!!";
		// 1. Get Session from SessionFactory
		Session session=HibernateUtils.getSessionFactory().getCurrentSession();
		//2. Begin Transacion
		Transaction tx=session.beginTransaction();
		try {
			session.persist(newUser);
			tx.commit();
			message="registered new user with ID"+newUser.getUserId();
		} catch (RuntimeException e) {
			// roll back Tx
			if(tx != null)
			{
				tx.rollback();
			}
			//re throw same exception to the caller
			throw e;
		}
		return message;
	}

}
