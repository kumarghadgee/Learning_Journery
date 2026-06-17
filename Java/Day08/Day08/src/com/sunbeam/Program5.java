package com.sunbeam;
import java.util.ArrayList;
import java.util.HashSet;
public class Program5 {

	
		public static void main(String[] args) {
			// TODO Auto-generated method stub
			ArrayList<Integer> set = new ArrayList<>();
			
			set.add(1);
			set.add(2);
			set.add(1);
			set.add(3);
			set.add(3);
			set.add(4);
			set.add(5);
			set.add(6);
			set.add(7);
			
			HashSet<Integer> dups = new HashSet<>();
			HashSet<Integer> number = new HashSet<>();
			for(int num : set) {
				if(number.contains(num)) {
					dups.add(num);
					System.out.println(num);
				}else {
					number.add(num);
				}
			}
		}

	}

