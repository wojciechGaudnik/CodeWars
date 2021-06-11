package heros_root.kyu7;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class IntSqRootTest {
	@Test
	public void test0() {
		System.out.println("Fixed Tests");
		assertEquals(4, IntSqRoot.IntRac(25, 1));
		assertEquals(4, IntSqRoot.IntRac(125348, 300), 3);
	}
}