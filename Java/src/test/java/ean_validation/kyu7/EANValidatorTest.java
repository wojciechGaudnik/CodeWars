package ean_validation.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class EANValidatorTest {
	@Test
	public void test_01() {
		assertTrue(EANValidator.validate("9783815820865"));
	}

	@Test
	public void test_02() {
		assertFalse(EANValidator.validate("9783815820864"));
	}

	@Test
	public void test_03() {
		assertTrue(EANValidator.validate("9783827317100"));
	}
}