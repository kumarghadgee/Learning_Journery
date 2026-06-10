package com.sunbeam;
import java.util.Scanner;
public class Program10 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the Year : ");
		int y = sc.nextInt();
		
		if((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) {
			System.out.println("Year " + y + "is Leap Year");
		}
		else {
			System.out.println("Year " + y + " is Not a Leap Year");
		}
		sc.close();
	}
}
