package com.sunbeam;
import java.util.Scanner;
public class Program4 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter any number : ");
        int num = sc.nextInt();
        int count = 0;
        if(num < 0) {
        	num = -num;
        }
        
        if(num == 0) {
        	count++;
        }
        
        while(num > 0) {
        	count++;
        	num/=10;
        }
        System.out.println(count);
        sc.close();
	}
}
