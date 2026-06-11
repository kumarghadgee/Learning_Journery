package com.sunbeam;
import java.util.Scanner;
public class Program2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the Number : ");
		int num = sc.nextInt();
		int sum = 0;
		for(int i = 0 ; i <= num ; i++) {
			sum =sum + i;
		}
		System.out.println("Sum of first N numbers : "+ sum);
		sc.close();
	}
}
