package com.sunbeam.dao;

import java.sql.SQLException;

public interface BaseDao {
	void cleanup() throws SQLException;
}
