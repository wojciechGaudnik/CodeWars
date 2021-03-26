package easy_line.kyu7;

import org.junit.jupiter.api.Test;

import java.math.BigInteger;

import static org.junit.Assert.assertEquals;

class EasylineTest {
	private static void testing(BigInteger actual, BigInteger expected) {
		assertEquals(expected, actual);
	}
	@Test
	public void test1() {
		testing(Easyline.easyLine(7),  new BigInteger("3432"));
		testing(Easyline.easyLine(13), new BigInteger("10400600"));
		testing(Easyline.easyLine(17), new BigInteger("2333606220"));
		testing(Easyline.easyLine(19), new BigInteger("35345263800"));
	}
}