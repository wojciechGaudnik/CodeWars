package thinkful_number_drills_congo_warehouses.kyu7;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	void basicTest() {
		assertEquals(13824, Kata.boxCapacity(32, 64, 16), String.format("For input l=%d, w=%d, h=%d", 32, 64, 16));
		assertEquals(3375, Kata.boxCapacity(20, 20, 20), String.format("For input l=%d, w=%d, h=%d", 20, 20, 20));
		assertEquals(27000, Kata.boxCapacity(80, 40, 20), String.format("For input l=%d, w=%d, h=%d", 80, 40, 20));
	}
}
