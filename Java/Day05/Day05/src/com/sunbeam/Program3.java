package com.sunbeam;

abstract class Payment{
	Payment(){
		
	}
	
	abstract void pay();
}

class UPI extends Payment{
	UPI(){
		
	}
	
	@Override
	public void pay() {
		System.out.println("UPI:PAY()");
	}
}

class creditCard extends Payment{
	@Override
	public void pay() {
		System.out.println("creditCard:Pay()");
	}
}
public class Program3 {
	public static void main(String[] args) {
	    Payment p;
	    
//	    p = new UPI();
	    p = new creditCard();
	    p.pay();
	}
}
