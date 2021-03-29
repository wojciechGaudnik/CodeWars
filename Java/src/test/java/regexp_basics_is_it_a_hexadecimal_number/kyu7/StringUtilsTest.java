package regexp_basics_is_it_a_hexadecimal_number.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

public class StringUtilsTest {
	@Test
	public void fixedTests() {
		assertFalse(StringUtils.isHexNumber(""));
		assertFalse(StringUtils.isHexNumber("0x"));
		assertTrue(StringUtils.isHexNumber("0"));
		assertTrue(StringUtils.isHexNumber("0xDEADBEEF"));
		assertTrue(StringUtils.isHexNumber("1337bAbe"));
	}
}