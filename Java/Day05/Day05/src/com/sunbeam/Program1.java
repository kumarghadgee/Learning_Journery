package com.sunbeam;

class Animal{
	String name;
	
	Animal(){
		
	}
	
	Animal(String name){
		this.name = name;
	}
	
	public void eat() {
		System.out.println(name+" Eat");
	}
	
	public void walk() {
		System.out.println(name+" Walk");
	}
	
	public void Display() {
		System.out.println(name);
	}
}

class Dog extends Animal{
	String breed;
	
	Dog(){
		
	}
	
	Dog(String breed){
		this.breed = breed;
	}
	
	@Override
	public void eat() {
		System.out.println(name +" Goldie  Eat()");
	}
	
	public void Display() {
		super.Display();
		System.out.println(breed);
	}
}

public class Program1 {
	public static void main(String[] args) {
		Dog d = new Dog();
		d.name = "Raya";
		d.breed = "Golden Retirever";
		d.Display();
		d.walk();
		d.eat();
	}
}
