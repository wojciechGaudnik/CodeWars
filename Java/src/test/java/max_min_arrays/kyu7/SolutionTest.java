package max_min_arrays.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertArrayEquals(new int[]{15,7,12,10,11},Solution.solve(new int[]{15,11,10,7,12}));
		assertArrayEquals(new int[]{15,7,12,10,11},Solution.solve(new int[]{15,11,10,7,12}));
		assertArrayEquals(new int[]{15,7,12,10,11},Solution.solve(new int[]{15,11,10,7,12}));
	}
}