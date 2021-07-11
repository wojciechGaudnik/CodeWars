package most_valuable_character.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests(){
//		assertEquals('a', Solution.solve("a"));
//		assertEquals('a', Solution.solve("aa"));
//		assertEquals('b', Solution.solve("bcd"));
//		assertEquals('x', Solution.solve("axyzxyz"));
		assertEquals('a', Solution.solve("dcbadcba"));
		assertEquals('c', Solution.solve("aabccc"));
		assertEquals('e', Solution.solve("efgefg"));
		assertEquals('e', Solution.solve("efghijefghi"));
		assertEquals('a', Solution.solve("acefacef"));
		assertEquals('a', Solution.solve("acefacefacef"));
	}
}