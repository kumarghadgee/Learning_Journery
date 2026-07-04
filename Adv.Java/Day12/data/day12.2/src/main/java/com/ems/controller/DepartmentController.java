package com.ems.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.ems.service.DepartmentService;

@Controller
@RequestMapping("/departments")
public class DepartmentController {
	//dependency - service layer i.f
	@Autowired
	private DepartmentService departmentService;
	
	public DepartmentController() {
		System.out.println("in ctor "+getClass());
	}
	/*
	 * Request handling method
	 * GET /departments/list
	 * Renders - LVN (Model) -> JSP
	 */
	@GetMapping("/list")
	public String renderDepartmentList(Model map)
	{
		System.out.println("in list depts "+map);//{}
		map.addAttribute("dept_list", departmentService.getAllDepartments());
		return "depts/list";//AVN - /WEB-INF/views/depts/list.jsp
	}

}
