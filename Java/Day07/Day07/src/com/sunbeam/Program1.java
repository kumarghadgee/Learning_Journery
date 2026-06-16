package com.sunbeam;
import java.util.ArrayList;

public class Program1 {
	public static void main(String[] args) {
		ArrayList<Integer> list = new ArrayList<>();
		list.add(10);
		list.add(20);
		list.add(30);
		list.add(40);
		list.add(50);
		
		list.set(1, 60);
		int Get = list.get(2);
		list.remove(3);
		
		for(int num : list) {
			System.out.println(num);
		}
		
		if(list.contains(40)) {
			System.out.println("Yes it contains");
		}else {
			System.out.println("No it doesn't contains");
		}
		
		System.out.println("Get : "+Get);
		System.out.println("Size : "+list.size());
		
		list.clear();
		System.out.println("Size : "+list.size());
	}
}
