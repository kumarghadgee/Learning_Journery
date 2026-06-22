package pages;

import jakarta.servlet.ServletConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.time.LocalTime;

/**
 * Servlet implementation class FirstServlet
 */
/*
	 WC at app startup time
	 -creates empty Map
	 -Key -> /test1 (Url pattern)
	 -Value -> pages.FirstServlet (Fully Qualified class name)
	 -runtime annotation, processed by WC
	 -at app start up , to create a mapping
	 -between incoming request & servlet
 */
@WebServlet(urlPatterns="/test1",loadOnStartup = 1)
public class FirstServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;   

	/**
	 * @see Servlet#init(ServletConfig)
	 */
	public void init() throws ServletException {
		// TODO Auto-generated method stub
			System.out.println("in init "+getClass());
	}

	/**
	 * @see Servlet#destroy()
	 */
	public void destroy() {
		// TODO Auto-generated method stub
		System.out.println("in destroy "+getClass());
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
			System.out.println("in doGet "+getClass());
			//1. set response content-type -> from the server side app-renders views (Web site)
			response.setContentType("text/html");
			//2. Get PrintWriter to send the dynamic response from the servlet -> client
			try(PrintWriter pw = response.getWriter()){
				pw.print("<h5>Hello From Servlet @ "+LocalTime.now()+"</h5>");
			} //JVM -> pw.close() -> response is committed | rendered | sent to client
	}

}
