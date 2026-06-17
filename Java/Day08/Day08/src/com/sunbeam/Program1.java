package com.sunbeam;

import java.util.Stack;

public class Program1 {
	public static void main(String[] args) {
		Stack<Integer> stk = new Stack<>();
		stk.push(10);
		stk.push(20);
		stk.push(30);
		stk.push(40);
		stk.push(50);
		stk.push(60);
		
		for(int num:stk) {
			System.out.println("Stk : "+num);
		}
		
		System.out.println();
		System.out.println("Popped : "+stk.pop());
		System.out.println("Popped : "+stk.pop());
		
		
		System.out.println();
		for(int num:stk) {
			System.out.println("After Pop : "+num);
		}
		
		System.out.println("Top Element : "+stk.peek());
		
		if(stk.isEmpty()) {
			System.out.println("Empty");
		}
		else {
			System.out.println("Not Empty");
		}
		
		while(!stk.isEmpty()) {
			stk.pop();
		}
		
		System.out.println();
		if(stk.isEmpty()) {
			System.out.println("2nd Empty");
		}
		else {
			System.out.println("2nd Not Empty");
		}
	}
}
