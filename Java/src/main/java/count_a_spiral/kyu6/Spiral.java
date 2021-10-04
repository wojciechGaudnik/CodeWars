package count_a_spiral.kyu6;

import java.math.BigInteger;

class Spiral {

	public static BigInteger sum(BigInteger size) {
		return size.pow(2).divide(BigInteger.TWO).add(size).subtract((size.mod(BigInteger.TWO).equals(BigInteger.ZERO)) ? BigInteger.ONE : BigInteger.ZERO);
	}
}
