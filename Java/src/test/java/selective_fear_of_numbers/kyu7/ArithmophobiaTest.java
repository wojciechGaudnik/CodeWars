package selective_fear_of_numbers.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class ArithmophobiaTest {
	@Test
	public void fixedTests() {
		doTest("Monday", 13, false);
		doTest("Sunday", -666, true);
		doTest("Tuesday", 2, false);
		doTest("Tuesday", 965, true);
		doTest("Friday", 2, true);
	}
	private void doTest(final String day, final int num, final boolean expected) {
		assertEquals("Should return "+Boolean.toString(expected),
				expected, Arithmophobia.AmIAfraid(day, num));
	}

}