package com.voting.dao;

import java.sql.*;

import com.voting.entities.User;
import com.voting.utils.DBUtils;

public class UserDaoImpl implements UserDao {
	private Connection connection;
	private PreparedStatement pst1, pst2;
	// dao 's constructor

	public UserDaoImpl() throws SQLException {
		// 1. get connection from DBUtils
		connection = DBUtils.getConnection();
		// 2. create PST - for user auth
		pst1 = connection.prepareStatement("select * from users where email=? and password=?");
		// 3. update status
		pst2 = connection.prepareStatement("update users set status=1 where id=?");
		System.out.println("user dao created !");
	}

	@Override
	public void cleanUp() throws SQLException {
		// close PSTs
		if (pst1 != null) {
			pst1.close();
		}
		if (pst2 != null) {
			pst2.close();
		}
		// close db cn
		if (connection != null) {
			connection.close();
		}
		System.out.println("user dao cleaned up !");

	}

	@Override
	public User authenticateUser(String email, String password) throws SQLException {
		// 1. set IN params
		pst1.setString(1, email);
		pst1.setString(2, password);
		// 2. execute queert to get RST(ResultSet)
		try (ResultSet rst = pst1.executeQuery()) {
			if (rst.next()) {
				// dev has to do ORM - JDBC
				return new User(rst.getLong(1), rst.getString(2), rst.getString(3), email, null, rst.getDate(6),
						rst.getBoolean(7), rst.getString(8));
			}
		}
		return null;
	}

	@Override
	public String updateVotingStatus(long voterId) throws SQLException {
		// set IN param
		pst2.setLong(1, voterId);
		int rowCount = pst2.executeUpdate();
		if (rowCount == 1)
			return "Voting status updated !";
		return "Updation failed !!!!";
	}

}
