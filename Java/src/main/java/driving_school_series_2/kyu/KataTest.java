package driving_school_series_2.kyu;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	void basicTest() {
		assertEquals(30, Kata.cost(1), "For input 1");
		assertEquals(30, Kata.cost(45), "For input 45");
		assertEquals(30, Kata.cost(63), "For input 63");
		assertEquals(40, Kata.cost(84), "For input 84");
		assertEquals(50, Kata.cost(102), "For input 102");
		assertEquals(100, Kata.cost(273), "For input 273");
	}

}
