package overflowing_with_longing.kyu7;

import java.math.BigInteger;

public class Multiplier {

	public static long multiply(long a, long b) {
		var abb = BigInteger.valueOf(a).multiply(BigInteger.valueOf(b));
		var abl = BigInteger.valueOf(a * b);
		if (abl.equals(abb)) {
			return abl.longValue();
		}
		throw new ArithmeticException();
	}
}
