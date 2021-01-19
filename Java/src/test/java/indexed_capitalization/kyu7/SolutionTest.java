package indexed_capitalization.kyu7;

import org.junit.jupiter.api.Test;

import static indexed_capitalization.kyu7.Solution.capitalize;
import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTest(){
		assertEquals("aBCdeF", capitalize("abcdef", new int[]{1,2,5}));
		assertEquals("aBCdeF", capitalize("abcdef", new int[]{1,2,5,100}));
		assertEquals("cOdEwArs", capitalize("codewars", new int[]{1,3,5,50}));
		assertEquals("abRacaDabRA", capitalize("abracadabra", new int[]{2,6,9,10}));
		assertEquals("codewArriors", capitalize("codewarriors", new int[]{5}));
	}

}