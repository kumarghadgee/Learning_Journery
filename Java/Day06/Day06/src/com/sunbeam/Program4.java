package com.sunbeam;

interface Cameraa{
	public void capturePhoto();
}

interface musicPlayer{
	public void playMusic();
}

class smartPhone implements Cameraa,musicPlayer{
	public void capturePhoto() {
		System.out.println("Photo clicked");
	}
	
	public void playMusic() {
		System.out.println("Music played");
	}
}

public class Program4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		smartPhone c;
		c = new smartPhone();
		c.capturePhoto();
		c.playMusic();
	}

}
