package com.ems.controller;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller // spring bean - req handling controller
/*
 * Add @RequestMapping 
 *  - at the class level
 *  - to add base URL pattern 
 */
@RequestMapping("/test") //optional BUT recommended !
public class TestController {
	public TestController() {
		System.out.println("in ctor " + getClass());
	}
	/*
	 * Req handling method
	 * HTTP Method - GET
	 * url-pattern - /test/test1
	 * Map 
	 * - key - GET /test/test1
	 * - value - TestController.testModelAndView
	 */
	@GetMapping("/test1")
	public ModelAndView testModelAndView() {
		System.out.println("in test model n view");
		/*
		 * o.s.w.s.ModelAndView(String LVN,String modelAttrName,Object modelAttrValue
		 */
		return new ModelAndView("display/test1", "server_ts", LocalDateTime.now());
		/*
		 * Handler rets ModelAndView -> D.S
		 * D.S -> LVN -> V.R -> AVN (/WEB-INF/views/display/test1.jsp) ->D.S
		 * D.S adds model attribute/s under req scope -> forward
		 * -> view layer -> JSP 
		 * EL - ${requestScope.server_ts}
		 * 
		 */
	}
	/*
	 * GET /test/test2
	 * Resp - LVN (Model Map)
	 */
	@GetMapping("/test2")
	public String testModelMap(Model modelMap)
	{
		System.out.println("in test model map "+modelMap);// {} - empty model attribute map
		//add model attributes
		modelMap.addAttribute("server_date", LocalDate.now())
		.addAttribute("server_time", LocalTime.now());
		return "display/test2";
	}
	/*
	 * Handler rets explicitly - LVN & implicitly Model attribute map -> D.S
	 * D.S -> LVN -> V.R -> AVN (/WEB-INF/views/display/test2.jsp) -> D.S
	 * D.S -> adds these model attributes -> request scope 
	 * -> forwards -> view layer 
	 * -> EL syntax
	 */
	
}
