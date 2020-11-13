package automorphic_number_special_numbers_series_6.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void One_Digit_Number()
	{
		assertEquals("Automorphic", Solution.autoMorphic(1));
		assertEquals("Not!!",       Solution.autoMorphic(3));
		assertEquals("Automorphic", Solution.autoMorphic(6));
		assertEquals("Not!!",       Solution.autoMorphic(9));
	}
	@Test
	public void Two_Digit_Number()
	{
		assertEquals("Automorphic", Solution.autoMorphic(25));
		assertEquals("Not!!",       Solution.autoMorphic(13));
		assertEquals("Automorphic", Solution.autoMorphic(76));
		assertEquals("Not!!",       Solution.autoMorphic(95));
	}
	@Test
	public void Larger_Number()
	{
		assertEquals("Automorphic", Solution.autoMorphic(625));
		assertEquals("Not!!",       Solution.autoMorphic(225));
		assertEquals("Not!!",       Solution.autoMorphic(425));
		assertEquals("Not!!",       Solution.autoMorphic(399));
	}
}