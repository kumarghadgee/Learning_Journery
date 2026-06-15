package com.sunbeam;

interface Camera{
	public void Photo();
}

class Phone implements Camera{
	public void Photo() {
		System.out.println("Phone : Photo()");
	}
}

class Drone implements Camera{

	public void Photo() {
		System.out.println("Drone : Photo()");
	}
}

public class Program1 {
	
	public static void main(String[] args) {
		Camera ca;
//		ca= new Phone();
		ca = new Drone();
		ca.Photo();
	}
}
