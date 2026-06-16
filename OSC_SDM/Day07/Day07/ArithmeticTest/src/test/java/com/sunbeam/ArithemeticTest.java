package com.sunbeam;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class ArithemeticTest {

	private Arithmetic ar;
	
	@BeforeEach
	void setupTest() {
		ar = new Arithmetic();
	}
	@Test
	void testAdd() {
		int actual = ar.Add(10, 20);
		int expected = 40;
		assertEquals(expected,actual);
	}
	
	@Test
	void testSubtract() {
		int actual = ar.Subtract(3500,3400);
		int expected = 100;
		assertEquals(expected,actual);
	}
	
	@Test
	void testMultiply() {
		int actual = ar.Multiply(35,100);
		int expected = 3500;
		assertEquals(expected,actual);
	}

}
