package determine_the_date_by_the_day_number.kyu6;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class KataTest {
	@Test
	void basicTest() {
		assertEquals("January, 15", Kata.getDay(15, false));
		assertEquals("February, 10", Kata.getDay(41, false));
		assertEquals("February, 28", Kata.getDay(59, false));
		assertEquals("March, 1", Kata.getDay(60, false));
		assertEquals("February, 29", Kata.getDay(60, true));
		assertEquals("December, 31", Kata.getDay(365, false));
		assertEquals("December, 31", Kata.getDay(366, true));
	}
}