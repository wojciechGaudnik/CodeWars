package consecutive_letters.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals(true,Solution.solve("abc"));
		assertEquals(false,Solution.solve("abd"));
		assertEquals(true,Solution.solve("dabc"));
		assertEquals(false,Solution.solve("abbc"));
		assertEquals(true,Solution.solve("v"));
	}
}