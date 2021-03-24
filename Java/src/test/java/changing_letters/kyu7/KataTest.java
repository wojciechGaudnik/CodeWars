package changing_letters.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void swap_1() {
		assertEquals("HEllOWOrld!",Kata.swap("HelloWorld!"));
	}

	@Test
	public void swap_2() {
		assertEquals("SUndAy",Kata.swap("Sunday"));
	}
}