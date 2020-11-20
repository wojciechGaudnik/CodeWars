package minimize_sum_of_array_array_series1.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests()
	{
		assertEquals( 22, Solution.minSum(new int[]{5,4,2,3}));
		assertEquals(342, Solution.minSum(new int[]{12,6,10,26,3,24}));
		assertEquals( 74, Solution.minSum(new int[]{9,2,8,7,5,4,0,6}));
	}

}