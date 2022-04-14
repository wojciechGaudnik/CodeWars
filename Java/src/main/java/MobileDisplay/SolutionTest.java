package MobileDisplay;


import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void testSomeValues1() {
		String solution = "***************************\n*                         *\n*                         *\n*                         *\n*        CodeWars         *\n*                         *\n*                         *\n*                         *\n*                         *\n* Menu           Contacts *\n***************************";
		assertEquals(solution, MobileDisplay.mobileDisplay(27, 41));
	}

	@Test
	public void testSomeValues2() {
		String solution = "************************************\n*                                  *\n*                                  *\n*                                  *\n*             CodeWars             *\n*                                  *\n*                                  *\n*                                  *\n*                                  *\n* Menu                    Contacts *\n************************************";
		assertEquals(solution, MobileDisplay.mobileDisplay(36, 31));
	}

	@Test
	public void testSomeValues3() {
		String solution =
				"***************************\n" +
						"*                         *\n" +
						"*                         *\n" +
						"*                         *\n" +
						"*        CodeWars         *\n" +
						"*                         *\n" +
						"*                         *\n" +
						"*                         *\n" +
						"*                         *\n" +
						"* Menu           Contacts *\n" +
						"***************************";
		assertEquals(solution, MobileDisplay.mobileDisplay(27, 41));
	}

	@Test
	public void testSomeValues4() {
		String solution = "************************************************************************\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                               CodeWars                               *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"*                                                                      *\n" +
				"* Menu                                                        Contacts *\n" +
				"************************************************************************";
		assertEquals(solution, MobileDisplay.mobileDisplay(72, 71));
	}

	@Test
	public void testSomeValues5() {
		String solution =
				"**************************************************************************************************\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                            CodeWars                                            *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"*                                                                                                *\n" +
						"* Menu                                                                                  Contacts *\n" +
						"**************************************************************************************************";
		assertEquals(solution, MobileDisplay.mobileDisplay(98, 78));
	}
}