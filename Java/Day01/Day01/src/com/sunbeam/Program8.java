package com.sunbeam;
import java.util.Scanner;
public class Program8 {
    public static void main(String[] args) {
    	Scanner sc = new Scanner(System.in);
    	System.out.println("Enter the 1st Number : ");
    	int n1 = sc.nextInt();
    	System.out.println("Enter the 2nd Number : ");
    	int n2 = sc.nextInt();
    	System.out.println("Enter the 3rd Number : ");
    	int n3 = sc.nextInt();
    	
    	if(n1 > n2 && n1 > n3) {
    		System.out.println("Greatest Number is n1 : " + n1);
    		if(n2 > n3) {
    			System.out.println("Smallest Number is n3 : " + n3);
    		}
    		else {
    			System.out.println("Smallest Number is n2 : "+ n2);
    		}
    	}
    	else if(n2 > n3) {
    		System.out.println("Greatest Number is n2 : "+ n2);
    		if(n1 > n3) {
    			System.out.println("Smallest Number is n3 : " + n3);
    		}
    		else {
    			System.out.println("Smallest Number is n1 : " + n1);
    		}
    	}
    	else {
    		System.out.println("Greatest Number is n3 : " + n3);
    		if(n1 > n2) {
    			System.out.println("Smallest Number is n2 : "+ n2);
    		}
    		else {
    			System.out.println("Smallest Number is n1 : " + n1);
    		}
    	}
    	sc.close();
    }
}
