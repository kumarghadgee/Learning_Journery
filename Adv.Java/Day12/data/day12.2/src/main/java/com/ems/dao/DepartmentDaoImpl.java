package com.ems.dao;

import java.util.List;

import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.ems.entities.Department;

@Repository // declares spring bean with DAO layer
public class DepartmentDaoImpl implements DepartmentDao {
	//dependency - SessionFactory
	@Autowired //SC tries to match by data type - 
	private SessionFactory sessionFactory;

	@Override
	public List<Department> getAllDepartments() {
		// TODO Auto-generated method stub
		return sessionFactory.getCurrentSession()
				.createQuery("select d from Department d", Department.class)
				.getResultList();
	}

}
