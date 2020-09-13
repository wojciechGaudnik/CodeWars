package summing_a_numbers_digits.kyu7;

import org.junit.Test;


public class KataTest {
	@Test
	void "Basic tests"() {
		println "Testing for 10"
		assert Kata.sumDigits(10) == 1
		println "Testing for 99"
		assert Kata.sumDigits(99) == 18
		println "Testing for -32"
		assert Kata.sumDigits(-32) == 5
	}

}