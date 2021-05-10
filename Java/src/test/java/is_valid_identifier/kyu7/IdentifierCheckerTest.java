package is_valid_identifier.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class IdentifierCheckerTest {
	@Test
	public void testValid() {
		assertEquals(true, IdentifierChecker.isValid("i1"));
	}

	@Test
	public void testInvalid() {
		assertEquals(false, IdentifierChecker.isValid("1i"));
	}

	@Test
	public void test1() {
		assertEquals(false, IdentifierChecker.isValid("str-str"));
	}

	@Test
	public void test2() {
		assertEquals(true, IdentifierChecker.isValid("___"));
	}

}