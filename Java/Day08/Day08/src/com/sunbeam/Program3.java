package com.sunbeam;

import java.util.Stack;

public class Program3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Stack<Integer> sk = new Stack<>();
		
		sk.push(10);
		sk.push(20);
		sk.push(30);
		sk.push(40);
		
		System.out.println(sk.peek());
		
		System.out.println(sk.pop());
		
		for(int num:sk) {
			System.out.print(num+" ");
		}
	}

}
