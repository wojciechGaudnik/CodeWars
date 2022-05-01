package previous_multiple_of_three.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	void basicTest() {
		assertEquals(null, Kata.prevMultOfThree(1), "For input 1");
		assertEquals(null, Kata.prevMultOfThree(25), "For input 25");
		assertEquals(36, Kata.prevMultOfThree(36), "For input 36");
		assertEquals(12, Kata.prevMultOfThree(1244), "For input 1244");
		assertEquals(9, Kata.prevMultOfThree(952406), "For input 952406");
	}
}
