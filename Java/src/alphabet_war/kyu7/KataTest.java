package alphabet_war.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class KataTest {
	@Test
	public void BasicTest() {
		assertEquals("Right side wins!", Kata.alphabetWar("z"));
		assertEquals("Let's fight again!", Kata.alphabetWar("zdqmwpbs"));
		assertEquals("Right side wins!", Kata.alphabetWar("zzzzs"));
		assertEquals("Left side wins!", Kata.alphabetWar("wwwwwwz"));
	}
}