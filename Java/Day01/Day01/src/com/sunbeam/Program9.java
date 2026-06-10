package com.sunbeam;
import java.util.Scanner;
public class Program9 {
    public static void main(String[] args) {
    	Scanner sc = new Scanner(System.in);
    	System.out.println("Enter the Number : ");
    	int n = sc.nextInt();
    	
    	if(n >= 1) {
    		System.out.println("Number is Positive : " + n);
    	}
    	else if(n < 0) {
    		System.out.println("Number is Negative : " + n);
    	}
    	else {
    		System.out.println("Number is Zero : " + n);
    	}
    	sc.close();
    }
}
