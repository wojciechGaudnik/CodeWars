package harvest_festival.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void sampleTests() {
		assertEquals("---,,,,,,,---,,,,,,,---,,,,,,,", Kata.plant(',', 3, 7, 25));
		assertEquals("-+", Kata.plant('+', 1, 3, 15));
		assertEquals("---------^", Kata.plant('^', 3, 3, 35));
		assertEquals("---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;---------;;;;;;;;;;", Kata.plant(';', 9, 10, 30));
	}
}