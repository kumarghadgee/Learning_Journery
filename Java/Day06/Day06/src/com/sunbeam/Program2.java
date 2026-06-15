package com.sunbeam;

interface flyable{
	public void fly();
}

class Bird implements flyable {
	public void fly() {
		System.out.println("Bird is flying");
	}
}

class Airplane implements flyable{
	public void fly() {
		System.out.println("Airplane is flying");
	}
}

public class Program2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		flyable fy;
//		fy = new Bird();
		fy = new Airplane();
		fy.fly();
	}

}
