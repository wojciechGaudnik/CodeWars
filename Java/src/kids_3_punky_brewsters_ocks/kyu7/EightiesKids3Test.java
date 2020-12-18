package kids_3_punky_brewsters_ocks.kyu7;

import org.junit.jupiter.api.Test;

import java.util.Arrays;
import java.util.Collections;

import static org.hamcrest.CoreMatchers.hasItems;
import static org.junit.Assert.assertThat;
import static org.junit.jupiter.api.Assertions.*;

class EightiesKids3Test {


	@Test
	public void testPunky() {
		String[] socks = new String[] { "pink", "argyle", "argyle" };
		String[] chosenSocks = EightiesKids3.getSocks("Punky", socks);
		assertNotNull(chosenSocks);
		assertEquals(2, chosenSocks.length);
		assertNotEquals(chosenSocks[0], chosenSocks[1]);
		assertThat(Arrays.asList(socks), hasItems(chosenSocks));
	}

	@Test
	public void testHenry() {
		String[] socks = new String[] { "red", "blue", "blue", "green" };
		String[] chosenSocks = EightiesKids3.getSocks("Henry", socks);
		assertNotNull(chosenSocks);
		assertEquals(2, chosenSocks.length);
		assertEquals(chosenSocks[0], chosenSocks[1]);
		assertTrue(Collections.frequency(Arrays.asList(socks), chosenSocks[0]) >= 2);
	}

	@Test
	public void testNoSolution() {
		String[] socks = new String[] { "green" };
		assertArrayEquals(new String[0], EightiesKids3.getSocks("Henry", socks));
	}
}