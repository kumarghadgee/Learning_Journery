package com.sunbeam;
import java.util.Scanner;

public class Program2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
	    System.out.println("Enter the Celisus : ");
	    double cel = sc.nextDouble();
	    
	    double fara = cel * 1.8 + 32;
	    
	    System.out.println("Celisus to fahrenheit is celisus = " + cel + " into fahreneit = " + fara);
	    sc.close();
	}
}
