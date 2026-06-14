package com.sunbeam;

class Shape{
	public void Draw() {
		System.out.println("Shape()");
	}
}

class Rectangle extends Shape{
	@Override
	public void Draw() {
		System.out.println("Rectangle()");
	}
}

class Square extends Shape{
	@Override
	public void Draw() {
		System.out.println("Sqaure()");
	}
}

public class Program2 {
	public static void main(String[] args) {
		Shape s;
		
//		s = new Shape();
//		s.Draw();
		
//		s = new Square();
//		s.Draw();
		
		s = new Rectangle();
		s.Draw();
	}
}
