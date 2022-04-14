package Dinglemouse2;

import org.junit.Test;

import static org.junit.Assert.*;

public class DinglemouseTest {
	private static final double epsilon = 0.00001;

	@Test
	public void example() {
		// assertEquals("expected", "actual");
		assertEquals(Math.sqrt(125), Dinglemouse.zigZagCamel(10, 5), epsilon);
	}

}