package find_last_fibonacci_digit_hardcore_version.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void basicTests() {
		assertEquals("For n = 1", 1, Kata.lastFibDigit(1));
		assertEquals("For n = 21", 6, Kata.lastFibDigit(21));
		assertEquals("For n = 302", 1, Kata.lastFibDigit(302));
		assertEquals("For n = 4003", 7, Kata.lastFibDigit(4003));
		assertEquals("For n = 50004", 8, Kata.lastFibDigit(50004));
		assertEquals("For n = 600005", 5, Kata.lastFibDigit(600005));
		assertEquals("For n = 7000006", 3, Kata.lastFibDigit(7000006));
		assertEquals("For n = 80000007", 8, Kata.lastFibDigit(80000007));
		assertEquals("For n = 900000008", 1, Kata.lastFibDigit(900000008));
		assertEquals("For n = 1000000009", 9, Kata.lastFibDigit(1000000009));
	}
}