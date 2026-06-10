package com.sunbeam;
import java.util.Scanner;
public class Program11 {
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int choice;
		do {
			
			System.out.println("Enter Your First Number : ");
			int a = sc.nextInt();
			System.out.println("Enter Your First Number : ");
			int b = sc.nextInt();
			System.out.println("0.Exit");
			System.out.println("1.Add");
			System.out.println("2.Sub");
			System.out.println("3.Mul");
			System.out.println("4.Div");
			System.out.println("5.Mod");
			System.out.println("Please Enter Your Choice : ");
		    choice = sc.nextInt();
		    
		    switch(choice) {
		    
		    case 1:
		    	System.out.println(a + b);
		    	break;
		    	
		    case 2:
		    	System.out.println(a - b);
		    	break;
		    	
		    case 3:
		    	System.out.println(a * b);
		    	break;
		    	
		    case 4:
		    	System.out.println(a / b);
		    	break;
		    	
		    case 5:
		    	System.out.println(a % b);
		    	break;
            
		    case 0:
		    	System.out.println("Exiting the Calculator.....");
		    	break;
		    	
		    default :
		    	System.out.println("Invalid Input.....");
		    	
		    
		    }
		}while(choice!=0);
		
		sc.close();
	}
}
