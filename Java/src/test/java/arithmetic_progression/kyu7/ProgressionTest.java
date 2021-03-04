package arithmetic_progression.kyu7;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class ProgressionTest {
	@Test
	public void shouldPassFixedTests() {
		Assertions.assertEquals("1, 2, 3, 4, 5, 6, 7, 8, 9, 10", Progression.arithmeticSequenceElements(1, 1, 10));
		Assertions.assertEquals("1, 3, 5, 7, 9", Progression.arithmeticSequenceElements(1, 2, 5));
		Assertions.assertEquals("1, 1, 1, 1, 1", Progression.arithmeticSequenceElements(1, 0, 5));
		Assertions.assertEquals("1, -2, -5, -8, -11, -14, -17, -20, -23, -26", Progression.arithmeticSequenceElements(1, -3, 10));
		Assertions.assertEquals("100, 90, 80, 70, 60, 50, 40, 30, 20, 10", Progression.arithmeticSequenceElements(100, -10, 10));
	}
}