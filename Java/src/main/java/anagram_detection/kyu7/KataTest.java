package anagram_detection.kyu7;

import org.junit.jupiter.api.Test;

import static junit.framework.Assert.assertEquals;

class KataTest {
	@Test
	public void exampleTests() {
		Kata k = new Kata();

		assertEquals(true, k.isAnagram("foefet", "toffee"));
		assertEquals(true, k.isAnagram("Buckethead", "DeathCubeK"));
		assertEquals(true, k.isAnagram("Twoo", "Woot"));
		assertEquals(false, k.isAnagram("apple", "pale"));
	}
}