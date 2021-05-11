package age_range_compatibility_equation.kyu8;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void exampleTests(){
		assertEquals("15-20", Kata.datingRange(17));
		assertEquals("27-66", Kata.datingRange(40));
		assertEquals("14-16", Kata.datingRange(15));
		assertEquals("24-56", Kata.datingRange(35));
		assertEquals("9-11", Kata.datingRange(10));
	}
}