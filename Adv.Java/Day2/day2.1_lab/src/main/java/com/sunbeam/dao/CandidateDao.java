package com.sunbeam.dao;

import java.sql.SQLException;
import java.util.List;

import com.sunbeam.entities.Candidate;

public interface CandidateDao extends BaseDao{
	List<Candidate> getAllCandidates() throws SQLException;
}
