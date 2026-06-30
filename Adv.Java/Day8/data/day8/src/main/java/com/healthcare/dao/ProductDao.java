package com.healthcare.dao;
import java.time.LocalDate;
import java.util.List;

import com.healthcare.entities.Product;
import com.healthcare.entities.ProductCategory;

public interface ProductDao {
	String addProduct(Product newProduct );
	
	List<Product> getAllProductsByRange(Integer minPrice,Integer maxPrice);
	
	List<Integer> allQuantityList(LocalDate date,ProductCategory category);
	
	String changePrice(String name,Double price);
}
