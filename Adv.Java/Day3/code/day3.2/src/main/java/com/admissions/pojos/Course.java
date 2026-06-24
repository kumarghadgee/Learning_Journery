package com.admissions.pojos;

public enum Course {
	CORE_JAVA(75), WEB_JAVA(80), MICROSERVICES(85), MERN(70);

	private int minScore;

	private Course(int minScore) {
		this.minScore = minScore;
	}

}
