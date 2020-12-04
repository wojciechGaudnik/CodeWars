package tidy_number_special_numbers_series9.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {

	@Test
	public void Check_Small_Values()
	{
		assertEquals(true,  Solution.tidyNumber(12));
		assertEquals(false, Solution.tidyNumber(32));
		assertEquals(true,  Solution.tidyNumber(39));
	}
	@Test
	public void Check_Larger_Values()
	{
		assertEquals(false, Solution.tidyNumber(1024));
		assertEquals(false, Solution.tidyNumber(12576));
		assertEquals(true,  Solution.tidyNumber(13579));
		assertEquals(true,  Solution.tidyNumber(2335));
	}

}