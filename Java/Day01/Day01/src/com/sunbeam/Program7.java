package com.sunbeam;
import java.util.Scanner;
public class Program7 {
     public static void main(String[] args) {
    	 Scanner sc = new Scanner(System.in);
    	 System.out.println("Enter the Principle Amount  : ");
    	 double pa = sc.nextDouble();
    	 System.out.println("Enter the Rate Of Interest  : ");
    	 int r = sc.nextInt();
    	 System.out.println("Enter the Time : ");
    	 int t = sc.nextInt();
    	 
    	 double si = (pa * r * t) / 100;
    	 
    	 System.out.println("Simple Interest  : "+ si);
    	 sc.close();	
     }
}
