package simple_fibonacci_strings.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
public class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("0", Solution.solve(0));
		assertEquals("01", Solution.solve(1));
		assertEquals("010", Solution.solve(2));
		assertEquals("01001", Solution.solve(3));
		assertEquals("0100101001001", Solution.solve(5));
	}
}