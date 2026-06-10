package com.sunbeam;
import java.util.Scanner;

public class Program3 {
     public static void main(String[] args) {
    	 Scanner sc = new Scanner(System.in);
    	 System.out.print("Enter your name : ");
    	 String name = sc.nextLine();
    	 System.out.print("Enter your age : ");
    	 int age = sc.nextInt();
    	 System.out.print("Enter your percentage : ");
    	 double percentage = sc.nextDouble();
    	 
    	 if(percentage >= 35 && percentage <= 100) {
    		 System.out.println("You are Passed in the Examination");
    	 }
    	 else if(percentage <= 34 && percentage >= 1) {
    		 System.out.println("You are Failed in the Examination");
    	 }else {
    		 System.out.println("Invalid input.......");
    	 }
    	 
    	 System.out.println("=============STUDENT DETAILS==================");
    	 System.out.println("Name          : " + name);
    	 System.out.println("Age           : " + age);
    	 System.out.println("Percentage    : " + percentage + "%");
     }
}
