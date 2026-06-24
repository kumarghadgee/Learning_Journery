package com.voting.entities;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

//id | name              | party    | votes
@NoArgsConstructor
@AllArgsConstructor
@Getter
@Setter
@ToString
public class Candidate {
	private long candidateId;
	private String candidateName;
	private String partyName;
	private int votes;

}
