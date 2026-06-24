package com.voting.dao;

import java.sql.SQLException;
import java.util.List;

import com.voting.entities.Candidate;

public interface CandidateDao extends BaseDao {
//list all candidates
	List<Candidate> getAllCandidates() throws SQLException;
	//update votes
	String incrementCandidateVotes(long candidateId) throws SQLException;
}
