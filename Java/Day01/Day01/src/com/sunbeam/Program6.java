package com.sunbeam;
import java.util.Scanner;
public class Program6 {
    public static void main(String[] args) {
    	System.out.println("Printing the remainder of two numbers.....");
    	
    	Scanner sc = new Scanner(System.in);
    	System.out.println("Enter the Dividened : ");
    	int a = sc.nextInt();
    	System.out.println("Enter the Divisor : ");
    	int b = sc.nextInt();
    	
    	int remainder = a % b;
    	
    	System.out.println("Remainder of Two Numbers are : "+ remainder );
    	sc.close();
    }
}
