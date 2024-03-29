package simple_fun_2_circle_of_numbers.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class CircleOfNumbersTest {
	@Test
	public void basicTests() {
		assertEquals(7, CircleOfNumbers.circleOfNumbers(10, 2));
		assertEquals(2, CircleOfNumbers.circleOfNumbers(10, 7));
		assertEquals(3, CircleOfNumbers.circleOfNumbers(4, 1));
		assertEquals(0, CircleOfNumbers.circleOfNumbers(6, 3));
		assertEquals(10, CircleOfNumbers.circleOfNumbers(20, 0));
		assertEquals(395, CircleOfNumbers.circleOfNumbers(562, 114));
		assertEquals(818, CircleOfNumbers.circleOfNumbers(918, 359));
	}
}