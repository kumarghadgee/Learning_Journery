package com.sunbeam;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class GeometryTest {

	private Geometry ge;
	
	@BeforeEach
	public void setupGeometry() {
		ge = new Geometry();
	}
	@Test
	void test() {
	   int actual = ge.CalcRectArea(30,5);
	   int expected = 150;
	   assertEquals(expected,actual);
	}

}
