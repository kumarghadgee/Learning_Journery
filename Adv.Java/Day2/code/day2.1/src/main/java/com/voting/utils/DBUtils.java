package com.voting.utils;

import java.sql.*;

public class DBUtils {
	private final static String dbURL = "jdbc:mysql://localhost:3306/voting";
	private final static String userName = "root";
	private final static String password = "root";
	
	//add static method to return DB connection to the caller
	public static Connection getConnection() throws SQLException
	{
		return DriverManager.getConnection(dbURL, userName, password);
	}
	
}
