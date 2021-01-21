package simple_remove_duplicates.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertArrayEquals(new int[]{4,6,3},Solution.solve(new int[]{3,4,4,3,6,3}));
		assertArrayEquals(new int[]{1,2,3},Solution.solve(new int[]{1,2,1,2,1,2,3}));
		assertArrayEquals(new int[]{1,2,3,4},Solution.solve(new int[]{1,2,3,4}));
		assertArrayEquals(new int[]{4,5,2,1},Solution.solve(new int[]{1,1,4,5,1,2,1}));
	}
}