package area_of_a_circle.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.fail;

class CircleTest {
	@Test
	public void testKnownValues() {
		try {
			Circle.area(0);
			fail("Radius of 0 should throw an IllegalArgumentException");
		} catch (IllegalArgumentException iae) {
		}
		for (int i = 0; i < 3; i++) {
			double x = 3D;
			assertEquals(28.27D, Circle.area(x), 0.01);
		}
	}
}