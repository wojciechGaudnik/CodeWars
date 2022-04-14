package SimpleStringDivision;

import static org.junit.Assert.*;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

import org.junit.runners.JUnit4;

public class SampleTest {
	@Test
	public void basicTests() {
		doTest("1 2 36 4 8", 2, 16);
		doTest("1 2 36 4 8", 3, 8);
		doTest("1 2 36 4 8", 4, 11);
		doTest("1 2 36 4 8", 8, 4);
	}

	private void doTest(String s, int k, int expected) {
		assertEquals(expected, SimpleStringDivision.solve(s, k));
	}
};