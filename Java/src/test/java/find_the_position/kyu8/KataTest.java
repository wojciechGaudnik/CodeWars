package find_the_position.kyu8;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void basicTests() {
		assertEquals("Position of alphabet: 1", Kata.position('a'));
		assertEquals("Position of alphabet: 26", Kata.position('z'));
		assertEquals("Position of alphabet: 5", Kata.position('e'));
	}
}