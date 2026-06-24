package com.voting.dao;

import java.sql.SQLException;
import java.util.List;

import com.voting.entities.Candidate;
import com.voting.entities.PartyVotes;

public interface CandidateDao extends BaseDao {
//list all candidates
	List<Candidate> getAllCandidates() throws SQLException;
	//update votes
	String incrementCandidateVotes(long candidateId) throws SQLException;
	
	List<Candidate> getTop2Candidates() throws SQLException;
	
	List<PartyVotes> partywiseAnalysis() throws SQLException;
}
