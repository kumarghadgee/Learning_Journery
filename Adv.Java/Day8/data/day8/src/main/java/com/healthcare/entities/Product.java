package com.healthcare.entities;

import java.time.LocalDate;

import org.hibernate.annotations.CreationTimestamp;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

//lombok annotations
@NoArgsConstructor
@Getter
@Setter
@ToString
//hibernate annotations
@Entity
public class Product {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name="product_id")
	private Long productId;
	@Column(name="product_name",length=50,unique=true)
	private String productName;
	@Column(name="product_description",length=300)
	private String productDescription;
	@CreationTimestamp
	@Column(name="manufacture_date")
	private LocalDate manufactureDate;
	private Double price;
	private Integer quantity;
	@Column(name="product_category")
	@Enumerated(EnumType.STRING)
	private ProductCategory productCategory;
	
	public Product(String pname, String description, Double price, Integer qty, ProductCategory pCategory) {
		// TODO Auto-generated constructor stub
		this.productName = pname;
		this.productDescription = description;
		this.price = price;
		this.quantity = qty;
		this.productCategory = pCategory;
	}
}
