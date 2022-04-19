package binary_sXORe.kyu7;

import org.junit.Test;

import java.math.BigInteger;

import static org.junit.Assert.assertEquals;


public class BinarySxoreTests {
	private static void tester(BigInteger inp, BigInteger exp) {
		assertEquals(exp, BinarySxore.sxore(inp));
	}

	@Test
	public void exampleTests() {
		tester(new BigInteger("0"), new BigInteger("0"));
		tester(new BigInteger("1"), new BigInteger("1"));
		tester(new BigInteger("50"), new BigInteger("51"));
		tester(new BigInteger("1000000"), new BigInteger("1000000"));
	}
}