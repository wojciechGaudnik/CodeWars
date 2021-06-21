package simple_equation_reversal.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("y/b*100",Solution.solve("100*b/y"));
		assertEquals("30*d/c-b+a",Solution.solve("a+b-c/d*30"));
		assertEquals("50+c/b*a",Solution.solve("a*b/c+50"));
	}
}