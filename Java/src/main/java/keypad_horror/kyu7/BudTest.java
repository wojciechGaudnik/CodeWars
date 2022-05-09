package keypad_horror.kyu7;

import org.junit.jupiter.api.Test;
		import static org.junit.jupiter.api.Assertions.assertEquals;

class BudTest {

	@Test
	void basicTest() {
		assertEquals("0123456789", Bud.computerToPhone("0789456123"), "For input \"0789456123\"");
		assertEquals("000", Bud.computerToPhone("000"), "For input \"000\"");
		assertEquals("34567", Bud.computerToPhone("94561"), "For input \"94561\"");
		assertEquals("", Bud.computerToPhone(""), "For empty input");
	}
}
