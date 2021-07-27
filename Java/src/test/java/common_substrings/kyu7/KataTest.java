package common_substrings.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {

	@Test
	public void ShouldBeTrue() {
		assertEquals(true, Kata.SubstringTest("Something", "Home"));
	}

	@Test
	public void ShouldBeFalse() {
		assertEquals(false, Kata.SubstringTest("Something", "Fun"));
	}
}