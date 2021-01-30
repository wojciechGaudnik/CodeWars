package insert_dashes.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void sampleTests() {
		assertEquals("4547-9-3", Solution.insertDash(454793));
		assertEquals("123456", Solution.insertDash(123456));
		assertEquals("1003-567", Solution.insertDash(1003567));
	}
}