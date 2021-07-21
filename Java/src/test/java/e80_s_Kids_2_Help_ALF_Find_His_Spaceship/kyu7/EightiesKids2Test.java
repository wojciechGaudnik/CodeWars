package e80_s_Kids_2_Help_ALF_Find_His_Spaceship.kyu7;

import org.junit.Test;
import static org.junit.Assert.*;

public class EightiesKids2Test {
	@Test
	public void test1x1Map() {
		assertEquals("[0, 0]", EightiesKids2.findSpaceship("X"));
	}

	@Test
	public void test2x2Map() {
		assertEquals("[0, 0]", EightiesKids2.findSpaceship("..\nX."));
		assertEquals("[1, 0]", EightiesKids2.findSpaceship("..\n.X"));
		assertEquals("[0, 1]", EightiesKids2.findSpaceship("X.\n.."));
		assertEquals("[1, 1]", EightiesKids2.findSpaceship(".X\n.."));
		assertEquals("Spaceship lost forever.", EightiesKids2.findSpaceship("..\n.."));
	}
}