package possibilities_array.kyu7;

import org.junit.Test;
		import static org.junit.Assert.assertEquals;
		import org.junit.runners.JUnit4;

public class SolutionTest {
	@Test
	public void simpleTests() {
		assertEquals(true, Solution.isAllPossibilities(new int[] {0, 1, 2, 3}));
		assertEquals(false, Solution.isAllPossibilities(new int[] {1, 2, 3, 4}));
		assertEquals(false, Solution.isAllPossibilities(new int[] {6, 0, 4}));
		assertEquals(false, Solution.isAllPossibilities(new int[] {6, 0, 4}));
	}
}