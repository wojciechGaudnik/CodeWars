package functions_of_integers_on_cartesian_plane.kyu7;

import java.math.BigInteger;

public class Funcij {

	public static BigInteger sumin(int n) {
		BigInteger sum = BigInteger.ZERO;
		for (var i = n; i > 0; i--) {
			sum = sum.add(BigInteger.valueOf((long) Math.pow(i, 2)));
		}
		return sum;
	}

	public static BigInteger  sumax(int n) {
		BigInteger sum = BigInteger.ZERO;
		for (int i = 1, j = 1; i <= n; i++, j += 2) {
			sum = sum.add(BigInteger.valueOf(i * j));
		}
		return sum;
	}

	public static BigInteger  sumsum(int n) {
		return sumin(n).add(sumax(n));
	}
}
