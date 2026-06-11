package com.sunbeam;
import java.util.Scanner;

public class Program05 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter any number : ");
        int num = sc.nextInt();
        
        int digit = num % 10;
        
        System.out.println(digit);
	}
} 
