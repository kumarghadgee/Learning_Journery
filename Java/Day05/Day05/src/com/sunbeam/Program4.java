package com.sunbeam;

abstract class Shape1{
	
//	public int side;

	abstract double area();
}

class Circle extends Shape1{
	
	double radius;
	
	Circle(){
		
	}
	
	Circle(double radius){
		this.radius = radius;
	}
	
	@Override
	public double area() {
		return 3.14 * radius * radius;
	}
}

class Square1 extends Shape1{
	
	double side;
	
	Square1(){
		
	}
	
	Square1(double side){
		this.side = side;
	}
	
	@Override
	public double area() {
		return Math.pow(side,2);
	}
}


public class Program4 {
	
	public static void main(String[] args) {
		Shape1 s = new Square1(10);
//		s.side = 10;
		System.out.println(s.area());
		
		Shape1 s1 = new Circle(10);
		System.out.println(s1.area());
	}
}
