package com.sunbeam;

import java.util.LinkedList;

public class Program2 {
	public static void main(String[] args) {
		LinkedList<Integer> list = new LinkedList<>();
		
		list.add(10);
		list.add(20);
		list.add(30);
		list.add(40);
		list.add(50);
		list.add(60);
		
		list.addFirst(5);
		list.addLast(65);
		
		for(int num:list) {
			System.out.println(num);
		}
		
		list.removeFirst();
		list.removeLast();
		
		System.out.println();
		System.out.println("After the removal");
		System.out.println();
		
		for(int num:list) {
			System.out.println(num);
		}
		
		System.out.println("GetFirst : "+ list.getFirst());
		System.out.println("GetLast : "+ list.getLast());
	}
}
