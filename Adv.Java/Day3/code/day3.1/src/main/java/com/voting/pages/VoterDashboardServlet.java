package com.voting.pages;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;

import com.voting.dao.CandidateDao;
import com.voting.dao.CandidateDaoImpl;
import com.voting.entities.Candidate;
import com.voting.entities.User;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

/**
 * Servlet implementation class VoterDashboardServlet
 */
@WebServlet(value = "/voter_dashboard", loadOnStartup = 2)
public class VoterDashboardServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private CandidateDao candidateDao;

	@Override
	public void init() throws ServletException {
		try {
			// create candidate dao instance
			candidateDao = new CandidateDaoImpl();
		} catch (Exception e) {
			throw new ServletException("err in init of " + getClass(), e);
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
			pw.print("in voter dashbaord<br/>");
			// 3. Get HttpSession from WC
			HttpSession hs = request.getSession(false);
			if (hs != null) {
				System.out.println("from voter dashboard  - session " + hs.isNew());// f : cookies accepted
				System.out.println("session id " + hs.getId());// same id
				// 4. Get user details from Session
				User user = (User) hs.getAttribute("user_details");
				pw.print("<h5> Hello , "+user.getFirstName()+" "+user.getLastName()+"</h5>");
				//5. invoke dao's method to get all candidates
				List<Candidate> candidates = candidateDao.getAllCandidates();
				//6. dynamic form generation
				pw.print("""
						<form method="post" action="logout">
						""");
				//7. iterate over the list & render radio buttons
				for(Candidate c : candidates)
				{
					pw.print("<input type='radio' name='cid' value="+c.getCandidateId()+">"+c.getCandidateName()+"<br/>");
				}
			
				pw.print("""	
						<input type='submit' value='Vote'/>
						</form>
						""");
			} else {
				pw.print("<h5> Session Tracking Failed !!!! You have to accept the cookies , to continue!!!!</h5>");
			}
		} catch (Exception e) {
			throw new ServletException("err in doGet "+getClass(), e);
		}
	}

	@Override
	public void destroy() {
		try {
			candidateDao.cleanUp();
		} catch (Exception e) {
			System.out.println("err in destroy " + getClass() + " " + e);
		}
	}

}
