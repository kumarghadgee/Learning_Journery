package com.sunbeam;
import java.util.Scanner;
public class Program6 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the Number : ");
	    int num = sc.nextInt();
	    int snum = num;
	    int rev = 0;
	    int digit = 0;
	    while(snum > 0) {
	    	digit = snum % 10;
	    	rev = rev * 10 + digit;
	    	snum /= 10;
	    }
	    
	    if(num == rev) {
	    	System.out.print("Number is Palindrome");
	    }
	    else {
	    	System.out.println("Number is Not Palindrome");
	    }
	}
}
