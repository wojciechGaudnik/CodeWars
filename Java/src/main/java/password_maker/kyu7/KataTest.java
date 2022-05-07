package password_maker.kyu7;

import org.junit.jupiter.api.Test;
		import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	void basicTest() {
		String a1 = "Give me liberty or give me death";
		String a2 = "Keep Calm and Carry On";
		assertEquals("Gml0gmd", Kata.makePassword(a1), String.format("For input \"%s\"", a1));
		assertEquals("KCaC0", Kata.makePassword(a2), String.format("For input \"%s\"", a2));
		assertEquals("", Kata.makePassword(""), String.format("For input \"%s\"", ""));
	}
}