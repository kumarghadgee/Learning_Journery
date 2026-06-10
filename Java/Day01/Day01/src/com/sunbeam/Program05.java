package com.sunbeam;
import java.util.Scanner;
public class Program05 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter A : ");
		int a = sc.nextInt();
		System.out.println("Enter B : ");
		int b = sc.nextInt();
		if(a > b) {
			System.out.println("A is greater than B");
		}
		else if(a == b) {
			System.out.println("A and B are equal");
		}
		else {
			System.out.println("B is greater than A");
		}
	}
}
