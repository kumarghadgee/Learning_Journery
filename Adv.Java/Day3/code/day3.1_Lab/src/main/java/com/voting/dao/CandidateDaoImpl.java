package com.voting.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import com.voting.entities.Candidate;
import com.voting.entities.PartyVotes;
import com.voting.utils.DBUtils;

public class CandidateDaoImpl implements CandidateDao {
	private Connection connection;
	private PreparedStatement pst1,pst2,pst3,pst4;
	public CandidateDaoImpl() throws SQLException{
		// get cn
		connection=DBUtils.getConnection();
		//pst1  - get all candidates
		pst1=connection.prepareStatement("select * from candidates");
		//pst2 - updates votes
		pst2=connection.prepareStatement("update candidates set votes=votes+1 where id=?");
		pst3=connection.prepareStatement("SELECT * FROM candidates ORDER BY votes DESC Limit 2");
		pst4=connection.prepareStatement("SELECT party, SUM(votes) FROM candidates GROUP BY party");
		System.out.println("candidate dao created");
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
				System.out.println("candidate dao cleaned up !");

	}

	@Override
	public List<Candidate> getAllCandidates() throws SQLException {
		List<Candidate> candidates=new ArrayList<>();
		try(ResultSet rst=pst1.executeQuery()) {
			while(rst.next())
				candidates.add(new Candidate(rst.getLong(1), rst.getString(2), rst.getString(3), rst.getInt(4)));
		}
		return candidates;
	}

	@Override
	public String incrementCandidateVotes(long candidateId) throws SQLException {
		//set IN param
		pst2.setLong(1, candidateId);
		//exec update
		int rowCount=pst2.executeUpdate();
		if (rowCount == 1)
			return "Votes updated !";
		return "Updation failed !!!!";
	}
	
	public List<Candidate> getTop2Candidates() throws SQLException{
		List<Candidate> cand = new ArrayList<>();
		try(ResultSet rst=pst3.executeQuery()){
			while(rst.next()) {
				// id | name              | party    | votes
				cand.add(new Candidate(rst.getLong(1), rst.getString(2), rst.getString(3), rst.getInt(4)));
			}
			return cand;
		}
	}
	
	public List<PartyVotes> partywiseAnalysis() throws SQLException{
		List<PartyVotes> candid = new ArrayList<>();
		try(ResultSet rst=pst4.executeQuery()){
			while(rst.next()) {
				candid.add(new PartyVotes(rst.getString(1),rst.getInt(2)));
			}
			return candid;
		}
		
	}

}
