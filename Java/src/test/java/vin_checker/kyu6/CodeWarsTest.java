package vin_checker.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
public class CodeWarsTest {
	@Test
	public void basicTestCases() {
		assertEquals("5YJ3E1EA7HF000337 should be valid!", true, CodeWars.checkVin("5YJ3E1EA7HF000337"));
		assertEquals("5YJ3E1EAXHF000347 should be valid!", true, CodeWars.checkVin("5YJ3E1EAXHF000347"));
		assertEquals("5VGYMVUX7JV764512 should be valid!", true, CodeWars.checkVin("5VGYMVUX7JV764512"));
		assertEquals("7WDMMTDV9TG739741 should be invalid!", false, CodeWars.checkVin("7WDMMTDV9TG739741"));
		assertEquals("7JTRH08L5EJ234829 should be invalid!", false, CodeWars.checkVin("7JTRH08L5EJ234829"));
	}
}