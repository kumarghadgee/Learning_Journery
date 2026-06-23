package com.voting.pages;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.Cookie;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

/**
 * Servlet implementation class VoterDashboardServlet
 */
@WebServlet("/voter_dashboard")
public class VoterDashboardServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// 1. set resp content type
		response.setContentType("text/html");
		// 2. Get writer
		try (PrintWriter pw = response.getWriter()) {
			pw.print("in voter dashbaord<br/>");
			//3 . Get cookie from request header
			Cookie[] cookies=request.getCookies();
			if(cookies != null) {
			pw.print("<h5> Hello ,"+cookies[0].getValue()+"</h5>");
			} else
			{
				pw.print("<h5> You have to accept the cookies , to continue!!!!</h5>");
			}
		}
	}

}
