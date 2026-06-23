package com.voting.pages;

import java.io.IOException;
import java.io.PrintWriter;

import com.voting.dao.UserDao;
import com.voting.dao.UserDaoImpl;
import com.voting.entities.User;

import jakarta.servlet.Servlet;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.Cookie;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class LoginServlet WC creates a URL Map Key - /auth
 * Value - com.voting.pages.LoginServlet
 */
@WebServlet(value = "/auth", loadOnStartup = 1)
public class LoginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	// dependency - dao layer interface
	private UserDao userDao;

	/**
	 * @see Servlet#init()
	 */
	public void init() throws ServletException {
		try {
			// create dao instance
			userDao = new UserDaoImpl();
		} catch (Exception e) {
		//throw ServletException(String mesg,Throwable rootCause) -> to WC
			throw new ServletException("err in init of "+getClass(),e);
		}
	}

	/**
	 * @see Servlet#destroy()
	 */
	public void destroy() {
		try {
		// dao's cleanup
		userDao.cleanUp();
		} catch (Exception e) {
			System.out.println("err in destroy "+e);
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		//1. set resp content type
		response.setContentType("text/html");
		//2. Get Writer -> PrintWriter
		try(PrintWriter pw=response.getWriter()) {
			//3. Read email & password sent form client
			String email=request.getParameter("em");
			String password=request.getParameter("pass");
		// 4. Call dao's authenticate - for user authentication
			User user = userDao.authenticateUser(email, password);
			//5 . In case of success - render user details otherwise render retry link with err mesg
			if(user == null) {
				//login failed 
				pw.print("<h5> Invalid Email or Password !!! Please <a href='login.html'>Retry</a></h5>");
			} else {
				
				//6. Create a cookie to store user name
				Cookie c1=new Cookie("user_name", user.getFirstName());
				//7. Add the cookie in resp header
				response.addCookie(c1);
				//role based navigation
				if(user.getRole().equals("admin")) {
					//admin logged in
					response.sendRedirect("admin_dashboard");
				} else if (user.isStatus()) {
					//voter has already voted 
					response.sendRedirect("logout");
				} else {
					//voter - not yet voted
					response.sendRedirect("voter_dashboard");
					/*
					 * Internals of redirect
					 * 1. WC clears(empties) response buffer (PW's buffer)
					 * 2. WC sends temp redirect resp to the client
					 *  - SC 302 , Header - Location : voter_dashboard 
					 *  Set-Cookie - user_name : user's first name
					 *  , body - empty
					 * 3. Web browser sends a NEW REDIRECT request to the server
					 * URL - http://host:port/ctx_path/voter_dashboard
					 * Method - GET
					 * Request Header - Cookie - user_name : user's first name
					 * -> VoterDashboard servlet
					 */
				}
			}
				
		}  catch (Exception e) {
			//inform WC - servicing has failed - for this request
			throw new ServletException("err in do-post of"+getClass(), e);
		}
	}

}
