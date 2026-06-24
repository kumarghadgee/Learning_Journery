package com.voting.pages;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;

import com.voting.dao.CandidateDao;
import com.voting.dao.CandidateDaoImpl;
import com.voting.entities.Candidate;
import com.voting.entities.PartyVotes;

/**
 * Servlet implementation class VoterDashboardServlet
 */
@WebServlet(value="/admin_dashboard",loadOnStartup = 4)
public class AdminDashboardServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private CandidateDao candidateDao;

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	@Override
	public void init() throws ServletException{
		try {
			candidateDao = new CandidateDaoImpl();
		}catch(Exception e) {
			throw new ServletException("Error in "+getClass() + " " + e);
		}
	}
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// 1. set resp content type
		response.setContentType("text/html");
		// 2. Get writer
		try (PrintWriter pw = response.getWriter()) {
			pw.print("in admin dashbaord");
			
			HttpSession hs = request.getSession(false);
			if(hs != null) {
				System.out.println("From admin Dashboard "+hs.isNew());
				System.out.println("Session Id : "+hs.getId());
				
				List<Candidate> cand = candidateDao.getTop2Candidates();
				for(Candidate c : cand) {
					pw.println("<br/>");
					pw.print(c +"<br/>");
				}
				
				List<PartyVotes> Pv = candidateDao.partywiseAnalysis();
				for(PartyVotes v : Pv) {
					pw.println("<br/>");
					pw.print(v +"<br/>" );
				}
			}else {
				pw.print("<h4>Session Tracking Failed, You have to accept the cookie to get access!!!!</h4>");
			}
		}catch(Exception e) {
			throw new ServletException("Error in the "+getClass(),e); 
		}
	}
	
	@Override
	public void destroy(){
		try {
			candidateDao.cleanUp();
		}catch(Exception e) {
			System.out.println("Error in "+getClass() + " "+e);
		}
	}

}
