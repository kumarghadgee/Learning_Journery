package com.voting.pages;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;

import com.voting.dao.CandidateDao;
import com.voting.dao.CandidateDaoImpl;
import com.voting.dao.UserDao;
import com.voting.dao.UserDaoImpl;
import com.voting.entities.User;

/**
 * Servlet implementation class VoterDashboardServlet
 */
@WebServlet(value = "/logout", loadOnStartup = 3)
public class LogoutServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private UserDao userDao;
	private CandidateDao candidateDao;

	@Override
	public void init() throws ServletException {
		try {
			userDao = new UserDaoImpl();
			candidateDao = new CandidateDaoImpl();
		} catch (Exception e) {
			throw new ServletException("err in init " + getClass(), e);
		}
	}

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
			// invalidate session
			HttpSession session = request.getSession(false);
			if (session != null) {
				session.invalidate();
			}

			pw.print("<h5> You have voted already....</h5> ");
			pw.print("<h5> You are logging out here...</h5> ");
		}
	}

	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		//voter has voted
		//1. set content type
		resp.setContentType("text/html");
		//2. get writer
		try(PrintWriter pw=resp.getWriter())
		{
			//3. Get HttpSession from WC
			HttpSession session=req.getSession(false);
			if(session != null)
			{
				//4. get user details from session
				User details=(User) session.getAttribute("user_details");
				pw.print("<h5> Hello, "+details.getFirstName()+" "+details.getLastName()+"</h5>");
				//5. invoke user dao's method to change voting status
				String status = userDao.updateVotingStatus(details.getUserId());
				System.out.println("update voting sts "+status);
				//6. increment candidate's votes
				long candidateId=Long.parseLong(req.getParameter("cid"));
				System.out.println("status "+				candidateDao.incrementCandidateVotes(candidateId));
				//7. invalidate session
				session.invalidate();
				pw.print("<h5>You have cast a vote &  You are logging out here...</h5> ");				
			}
			else {
				pw.print("<h5> Session Tracking Failed !!!! You have to accept the cookies , to continue!!!!</h5>");
			}
		} catch (Exception e) {
			throw new ServletException("err in doPost "+getClass(), e);
		}
	}

	@Override
	public void destroy() {
		try {
			userDao.cleanUp();
			candidateDao.cleanUp();
		} catch (Exception e) {
			System.out.println("in destory " + getClass() + " " + e);
		}

	}

}
