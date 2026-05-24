package Dsa;

import java.util.Scanner;

public class sortedArray {
	public static void main(String[] args) {
	    boolean isSorted = false;
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Enter the size of Array :");
		int size = sc.nextInt();
		
		int arr[] = new int[size];
		
		System.out.println("Enter the Elements in "+ size + " size of array : ");
		for(int i = 0; i < arr.length ;i++) {
			System.out.print("Element at "+ i + " index is : " );
			arr[i] = sc.nextInt();
		}
		
		for(int i = 1; i < arr.length; i++) {
			if(arr[i] >= arr[i-1]) {
				
			}
			else {
				System.out.println("Your Array is not in Sorted Manner...");
				isSorted = true;
			}
		}
		if(!isSorted) {
			System.out.println("Your Array is Sorted");
		}
	}
}