package strange_mathematics.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
public class StrangeTest {
	@Test
	public void sampleTestCases(){
		assertEquals("For n=11 and k=2: ", 4, Strange.mathematics(11, 2));
		assertEquals("For n=15 and k=5: ", 11, Strange.mathematics(15, 5));
		assertEquals("For n=15 and k=15: ", 7, Strange.mathematics(15, 15));
	}
}