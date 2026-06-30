package com.healthcare.entities;

import java.time.LocalDate;
import java.time.LocalDateTime;

import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.annotations.UpdateTimestamp;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

/*
 * users table 
column - id(PK) , created_on : date , last_updated : datetime
first name , last name, email ,password , dob:date ,phone role:enum,reg_amount :int

 */
//lombok 
@NoArgsConstructor
@Getter
@Setter
@ToString(exclude = "password")
//JPA annotations
//mandatory annotations
@Entity // mandatory cls level annotation to declare an entity class
@Table(name = "users") // to declare table name
public class User {
	@Id // mandatory field level annotation - to add PK constraint
	@GeneratedValue(strategy = GenerationType.IDENTITY) // adds auto increment constraint
	// default (strategy=GenerationType.AUTO)
	@Column(name = "user_id")
	private Long userId;
	@CreationTimestamp
	@Column(name="created_at")
	private LocalDate createdAt;
	@Column(name="last_updated")
	@UpdateTimestamp
	private LocalDateTime lastUpdated;
	@Column(name="first_name",length = 20)//varchar(20)
	private String firstName;	
	@Column(name="last_name",length = 30)//varchar(30)
	private String lastName;
	@Column(length = 50,unique = true)//adds UNIQUE constraint
	private String email;
	@Column(nullable = false)//NOT NULL constraint
	private String password;
	private LocalDate dob;
	@Column(length = 14,unique = true)
	private String phone;
	@Column(name="user_role")
	@Enumerated(EnumType.STRING) //col type - enum
	private UserRole userRole;
	@Column(name="reg_amount")
	private Integer regAmount;
	public User(String firstName, String lastName, String email, String password, LocalDate dob, String phone,
			UserRole userRole, Integer regAmount) {
		super();
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
		this.password = password;
		this.dob = dob;
		this.phone = phone;
		this.userRole = userRole;
		this.regAmount = regAmount;
	}
	
}
