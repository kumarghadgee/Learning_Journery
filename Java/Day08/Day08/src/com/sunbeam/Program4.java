package com.sunbeam;

import java.util.HashSet;

public class Program4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		HashSet<Integer> set = new HashSet<>();
		
		set.add(10);
		set.add(20);
		set.add(10);
		set.add(30);
		set.add(30);
		set.add(40);
		set.add(50);
		set.add(60);
		set.add(70);
//		System.out.println();
		for(int num:set) {
			if(set.contains(num)) {
				System.out.print("Removed : "+num);
			}else {
				System.out.print(num+" ");
			}
		}
		System.out.println();
		System.out.println("Size : " + set.size());
		
		
	}

}
