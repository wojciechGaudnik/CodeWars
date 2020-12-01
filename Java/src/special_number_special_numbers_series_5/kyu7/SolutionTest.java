package special_number_special_numbers_series_5.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void Check_Single_Digit_Number()
	{
		assertEquals("Special!!", Solution.specialNumber(2));
		assertEquals("Special!!", Solution.specialNumber(3));
		assertEquals("NOT!!", Solution.specialNumber(9));
		assertEquals("NOT!!", Solution.specialNumber(7));
	}
	@Test
	public void Two_Digit_Number()
	{
		assertEquals("Special!!", Solution.specialNumber(23));
		assertEquals("NOT!!", Solution.specialNumber(79));
		assertEquals("Special!!", Solution.specialNumber(32));
		assertEquals("NOT!!", Solution.specialNumber(39));
		assertEquals("Special!!", Solution.specialNumber(55));

	}
	@Test
	public void Larger_Sepcial_Number()
	{
		assertEquals("Special!!", Solution.specialNumber(513));
		assertEquals("NOT!!", Solution.specialNumber(709));
		assertEquals("NOT!!", Solution.specialNumber(538));

	}
	@Test
	public void Mega_Sepcial_Number()
	{
		assertEquals("Special!!", Solution.specialNumber(53532));
		assertEquals("NOT!!", Solution.specialNumber(970569));
		assertEquals("Special!!", Solution.specialNumber(11350224));

	}
}