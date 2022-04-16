package point_in_a_unit_circle.kyu7;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertTrue;
import static org.junit.jupiter.api.Assertions.assertFalse;

class SampleTests {
	@Test
	void origin() {
		assertTrue(Kata.pointInCircle(0, 0), "Origin is inside");
	}

	@Test
	void outsidePoint() {
		assertFalse(Kata.pointInCircle(2, 0), "(2, 0) is outside");
	}

	@Test
	void insidePoint1() {
		assertTrue(Kata.pointInCircle(0, 0.9), "(0, 0.9) is inside");
	}

	@Test
	void insidePoint2() {
		assertTrue(Kata.pointInCircle(0.5, 0.5), "(0.5, 0.5) is inside");
	}

	@Test
	void borderPoint() {
		assertFalse(Kata.pointInCircle(1, 0), "(1, 0) is on border and thus outside");
	}
}
