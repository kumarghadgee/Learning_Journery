package com.sunbeam;

interface A{
	public void A();
}

interface B{
	public void B();
}

class C implements A,B{
	public void A() {
		System.out.println("C : A()");
	}
	
	public void B() {
		System.out.println("C : B()");
	}
}

public class Program3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		C  c = new C();
		c.A();
		c.B();
	}

}
