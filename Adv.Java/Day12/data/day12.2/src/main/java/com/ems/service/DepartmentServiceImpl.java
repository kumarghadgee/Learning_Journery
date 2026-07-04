package com.ems.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.ems.dao.DepartmentDao;
import com.ems.entities.Department;

@Service //Spring bean - B.L
@Transactional //automatic Tx management - import it from o.s.transaction
public class DepartmentServiceImpl implements DepartmentService {
	//dependency 
	@Autowired //SC matches by data type - Field Level D.I
	private DepartmentDao departmentDao;

	@Override
	public List<Department> getAllDepartments() {
		// TODO Auto-generated method stub
		return departmentDao.getAllDepartments();
	}

}
