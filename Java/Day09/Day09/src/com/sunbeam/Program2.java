package com.sunbeam;

import java.util.HashMap;
import java.util.Scanner;

public class Program2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("Give any word to find the Frequency : ");
		String str = sc.next();
		
		HashMap<Character,Integer> map = new HashMap<>();
		
		for(char n : str.toCharArray()) {
			if(map.containsKey(n)) {
				map.put(n, map.get(n) + 1);
			}else {
				map.put(n, 1);
			}
		}
		
		for(Character key : map.keySet()) {
			System.out.println(key + " " + map.get(key));
		}
		sc.close();
	}

}
