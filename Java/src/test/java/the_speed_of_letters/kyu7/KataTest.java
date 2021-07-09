package the_speed_of_letters.kyu7;

import org.junit.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class KataTest {
	@Test
	public void exampleTests() {
		assertEquals(Kata.speedify("AZ"), "A                         Z");
		assertEquals(Kata.speedify("ABC"), "A B C");
		assertEquals(Kata.speedify("ACE"), "A  C  E");
		assertEquals(Kata.speedify("CBA"), "  A");
		assertEquals(Kata.speedify("HELLOWORLD"), "     E H    DLL   OLO   R  W");
	}
}