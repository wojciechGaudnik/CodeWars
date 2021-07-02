package thb.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class THBTest {
	@Test
	public void basicTest() {
		THB check = new THB();
		assertEquals("thhttttbbttt",
				check.testing("For those of you who would like to test your solution before submitting it."));
	}
}
