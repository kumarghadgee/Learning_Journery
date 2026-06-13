package com.sunbeam;

class Animal{
	String name;
	
	Animal(){
		
	}
	
	Animal(String name){
	   this.name = name;	
	}
	
	public void Eat() {
		System.out.println("Its can eat food");
	}
	
	public void Walk() {
		System.out.println("They can run walk and go left snd right");
	}
	
	public void Display() {
		System.out.println(name);
	}
}

class Dog extends Animal{
	String Color;
	
	Dog(){
		
	}

	Dog(String Color){
		super();
		this.Color = Color;
	}
	
	public void bark() {
		System.out.println("Dog Barks");
	}
	
	public void Display() {
		super.Display();
		System.out.println(Color);
	}
}

public class Program1 {

     public static void main(String[] args) {
    	 Dog d = new Dog(); 
    	 d.name = "Bruno";
    	 d.Color = "Golden";
    	 d.Eat();
    	 d.Walk();
    	 d.bark();
    	 d.Display();
    	 
     }
	
}
