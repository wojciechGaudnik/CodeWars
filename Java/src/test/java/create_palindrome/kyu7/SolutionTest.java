package create_palindrome.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals(true,Solution.solve("abba"));
		assertEquals(false,Solution.solve("abaazaba"));
		assertEquals(true,Solution.solve("abccba"));
		assertEquals(true,Solution.solve("adfa"));
		assertEquals(false,Solution.solve("ae"));
		assertEquals(true,Solution.solve("sq"));
		assertEquals(false,Solution.solve("abzy"));
		assertEquals(true,Solution.solve("kxbkwgyydkcbtjcosgikfdyhuuprubpwthgflucpyylbofvqxkkvqthmdnywpaunfihvupbwpruwfybdmgeuocltdaidyyewmbzm"));
		assertEquals(false, Solution.solve("gh"));
		assertEquals(false, Solution.solve("ab"));
	}
}