package sum_of_cubes.kyu7;


import org.junit.Test;

import static org.junit.Assert.assertEquals;

// TODO: Replace examples and use TDD by writing your own tests

public class SolutionTest {
	@Test
	public void exampleTests() {
		assertEquals(1,Solution.sumCubes(1));
		assertEquals(9,Solution.sumCubes(2));
		assertEquals(36,Solution.sumCubes(3));
		assertEquals(100,Solution.sumCubes(4));
		assertEquals(3025, Solution.sumCubes(10));
		assertEquals(58155876,Solution.sumCubes(123));
	}
}
