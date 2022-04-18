package binary_scORe.kyu7;

import java.math.BigInteger;
import static org.junit.Assert.*;
import org.junit.Test;

public class BinaryScoreTests {
	private static void tester (BigInteger inp, BigInteger exp) {
		assertEquals(exp, BinaryScore.score(inp));
	}

	@Test
	public void basicTests () {
		tester(new BigInteger("0"), new BigInteger("0"));
		tester(new BigInteger("1"), new BigInteger("1"));
		tester(new BigInteger("49"), new BigInteger("63"));
		tester(new BigInteger("1000000"), new BigInteger("1048575"));
		tester(new BigInteger("10000000"), new BigInteger("16777215"));
	}
}