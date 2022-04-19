package binary_sXORe.kyu7;

import java.math.BigInteger;

public class BinarySxore {

	public static BigInteger sxore(BigInteger n) {
		BigInteger mod = n.mod(BigInteger.valueOf(4));
		if (mod.equals(BigInteger.ZERO)) {
			return n;
		}
		if (mod.equals(BigInteger.ONE)) {
			return BigInteger.ONE;
		}
		if (mod.equals(BigInteger.TWO)) {
			return n.add(BigInteger.ONE);
		}
		return BigInteger.ZERO;
	}

}