package XOR;

import org.junit.Test;

import static org.junit.Assert.*;

public class XORTest {


	private static void testing(boolean actual, boolean expected) {
		assertEquals(expected, actual);
	}

	@Test
	public void testBasic() {
		System.out.println("Testing basics.");
		testing(XOR.xor(false, false), false);
		testing(XOR.xor(true, false), true);
		testing(XOR.xor(false, true), true);
		testing(XOR.xor(true, true), false);
	}
	@Test
	public void testNested() {
		System.out.println("Testing nested calls.");
		testing(XOR.xor(false, XOR.xor(false, false)), false);
		testing(XOR.xor(XOR.xor(true, false), false), true);
		testing(XOR.xor(XOR.xor(true, true), false), false);
		testing(XOR.xor(true, XOR.xor(true, true)), true);
		testing(XOR.xor(XOR.xor(false, false), XOR.xor(false, false)), false);
		testing(XOR.xor(XOR.xor(false, false), XOR.xor(false, true)), true);
		testing(XOR.xor(XOR.xor(true, false), XOR.xor(false, false)), true);
		testing(XOR.xor(XOR.xor(true, false), XOR.xor(true, false)), false);
		testing(XOR.xor(XOR.xor(true, true), XOR.xor(true, false)), true);
		testing(XOR.xor(XOR.xor(true, XOR.xor(true, true)), XOR.xor(XOR.xor(true, true), false)), true);
	}
}