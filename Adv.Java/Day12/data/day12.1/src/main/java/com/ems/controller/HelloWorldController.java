package com.ems.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller // class level annotation to declare a spring bean containing req handling logic
			// - Handler ,singleton & eager
public class HelloWorldController {
	public HelloWorldController() {
		System.out.println("in ctor " + getClass());
	}
	/*
	 * Request handling method
	 * Method - GET
	 * URI - /ctx_path/
	 * SC adds the entry in HandlerMapping
	 * Key - GET /
	 * Value - com.ems.controller.HelloWorldController.renderHomePage
	 */
	@GetMapping("/")
	public String renderHomePage() {
		System.out.println("in render home page ...");
		return "index";
	}
}
