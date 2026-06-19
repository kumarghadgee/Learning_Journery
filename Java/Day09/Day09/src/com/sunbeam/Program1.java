package com.sunbeam;

import java.util.HashMap;

public class Program1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		HashMap<Integer,String> map = new HashMap<>();
		map.put(101, "Kumar");
		map.put(102, "Gaurav");
		map.put(103, "Sairaj");
		map.put(104, "Sai");
		map.put(105, "Sheth");
		map.put(106, "Saheb");
		
		System.out.println("Get Value : "+map.get(102));
		System.out.println();
		System.out.println(map.containsKey(103));
		System.out.println();
		System.out.println("SIZE : "+map.size());
		System.out.println();
		for(String n : map.values()) {
			System.out.println(n);
		}
		
		System.out.println();
		
		System.out.println("Remove : " +map.remove(106));
		System.out.println();
		for(String n : map.values()) {
			System.out.println(n);
		}
		
	}

}
