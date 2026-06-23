package com.voting.entities;

import java.sql.Date;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

/*
 * id | first_name | last_name | email            | password | dob        | status | role 
 */
@NoArgsConstructor // generates default arg-less constructor
@AllArgsConstructor // generates parameterized ctor
@Getter //generates all getters 
@Setter //generates all setters
@ToString(exclude = "password") //generates toString with all fields w/o password
public class User {
	private long userId;
	private String firstName;
	private String lastName;
	private String email;
	private String password;
	private Date dob;
	private boolean status;
	private String role;
	
	

}
