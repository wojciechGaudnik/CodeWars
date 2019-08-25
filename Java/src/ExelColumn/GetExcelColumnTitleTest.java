package ExelColumn;

import org.junit.Test;

import static org.junit.Assert.*;

public class GetExcelColumnTitleTest {

	@Test
	public void examplesInDescriptionTest() {
		assertEquals("A", GetExcelColumnTitle.getColumnTitle(1));
		assertEquals("Z", GetExcelColumnTitle.getColumnTitle(26));
		assertEquals("AZ", GetExcelColumnTitle.getColumnTitle(52));
		assertEquals("BA", GetExcelColumnTitle.getColumnTitle(53));
		assertEquals("ZZ", GetExcelColumnTitle.getColumnTitle(702));
		assertEquals("AYK", GetExcelColumnTitle.getColumnTitle(1337));
		assertEquals("XPEH", GetExcelColumnTitle.getColumnTitle(432778));
	}
	@Test(expected=IllegalArgumentException.class)
	public void zeroInputShouldThrowIllegalArgumentException() {
		GetExcelColumnTitle.getColumnTitle(0);
	}
}