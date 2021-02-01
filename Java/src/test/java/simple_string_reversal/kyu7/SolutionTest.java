package simple_string_reversal.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("srawedoc",Solution.solve("codewars"));
		assertEquals("edoc ruoy",Solution.solve("your code"));
		assertEquals("skco redo cruoy",Solution.solve("your code rocks"));
	}
}