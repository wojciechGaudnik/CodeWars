package red_knight.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class CodeWarsTest {
	@Test
	public void should_return_the_output_provided() {
		CodeWars.PawnDistance actual = CodeWars.redKnight(0, 8);
		CodeWars.PawnDistance expected = new CodeWars.PawnDistance("White", 16);
		assertEquals(expected, actual);

		actual = CodeWars.redKnight(0, 7);
		expected = new CodeWars.PawnDistance("Black", 14);
		assertEquals(expected, actual);

		actual = CodeWars.redKnight(1, 6);
		expected = new CodeWars.PawnDistance("Black", 12);
		assertEquals(expected, actual);

		actual = CodeWars.redKnight(1, 5);
		expected = new CodeWars.PawnDistance("White", 10);
		assertEquals(expected, actual);
	}
}