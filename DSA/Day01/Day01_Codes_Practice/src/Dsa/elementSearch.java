package Dsa;

import java.util.Scanner;

public class elementSearch {
	public static Scanner sc = new Scanner(System.in);
	public static void main(String[] args) {
		int arr[] = {3,2,4,6,7,9,8,1};
	    System.out.print("Enter the Element from the array for searching : ");
	    int x = sc.nextInt();
	    boolean isFound = false;
	    for(int i = 0; i < arr.length ; i++) {
	    	if(arr[i] == x) {
	    		System.out.println("Your Element is at index : "+ i );
	    		isFound = true;
	    		break;
	    	}
	    }
	    if(!isFound) {
	    	System.out.println("Element Not Found");
	    }
	}
}