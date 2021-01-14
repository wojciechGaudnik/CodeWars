package simple_fun_missing_alphabets.kyu6;

import org.junit.Test;

import simple_fun_prime_string.kyu6.Kata;

import static org.junit.Assert.*;

public class SampleTestsJava {
	@Test
	public void sampleTests() {
		assertTrue(Kata.primeString("abac"));
		assertFalse(Kata.primeString("abab"));
		assertFalse(Kata.primeString("aaaa"));
		assertTrue(Kata.primeString("x"));
		assertTrue(Kata.primeString("abc"));
		assertFalse(Kata.primeString("fdsyffdsyffdsyffdsyffdsyf"));
		assertTrue(Kata.primeString("utdutdtdutd"));
		assertTrue(Kata.primeString("abba"));
	}
}
