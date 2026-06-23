package com.voting.dao;

import java.sql.SQLException;

import com.voting.entities.User;

public interface UserDao extends BaseDao {
//auth user
	User authenticateUser(String email,String password) throws SQLException;
}
