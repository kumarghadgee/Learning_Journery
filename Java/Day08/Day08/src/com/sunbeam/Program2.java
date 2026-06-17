package com.sunbeam;

import java.util.LinkedList;
import java.util.Queue;

public class Program2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Queue<Integer> que = new LinkedList<>();
		que.offer(10);
		que.offer(20);
		que.offer(30);
		que.offer(40);
		que.offer(50);
		que.offer(60);
		que.offer(70);
		
		que.poll();
		que.poll();
		que.poll();
		
		System.out.println();
		for(int num:que) {
			System.out.println("Queue : "+num);
		}
		
		System.out.println();
		System.out.println(que.peek());
		
		System.out.println();
		System.out.println("Queue : "+que);
	}

}
