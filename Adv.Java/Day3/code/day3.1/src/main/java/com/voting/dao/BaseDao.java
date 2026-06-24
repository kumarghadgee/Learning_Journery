package com.voting.dao;

import java.sql.SQLException;

public interface BaseDao {
	//for closing connection
	void cleanUp() throws SQLException;
}
