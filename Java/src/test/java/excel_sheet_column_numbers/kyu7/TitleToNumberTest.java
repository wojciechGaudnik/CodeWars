package excel_sheet_column_numbers.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class TitleToNumberTest {
	@Test
	public void test0() {
		System.out.println("Fixed Tests");
		assertEquals(1, TitleToNumber.titleToNumber("A"));
		assertEquals(27, TitleToNumber.titleToNumber("AA"));
		assertEquals(52, TitleToNumber.titleToNumber("AZ"));
		assertEquals(53, TitleToNumber.titleToNumber("BA"));
		assertEquals(28779382963L, TitleToNumber.titleToNumber("CODEWARS"));
	}
}