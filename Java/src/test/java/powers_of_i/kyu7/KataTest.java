package powers_of_i.kyu7;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void testSomething() {
		assertEquals("1",Kata.pofi(0));
		assertEquals("i",Kata.pofi(1));
		assertEquals("-1",Kata.pofi(2));
		assertEquals("-i",Kata.pofi(3));
		assertEquals("1",Kata.pofi(4));
		assertEquals("i",Kata.pofi(5));
		assertEquals("-1",Kata.pofi(6));
		assertEquals("-i",Kata.pofi(7));
		assertEquals("1",Kata.pofi(8));
		assertEquals("i",Kata.pofi(9));
		assertEquals("-1",Kata.pofi(10));
	}
}