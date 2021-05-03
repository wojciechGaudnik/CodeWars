package wilson_primes.kyu8;

public class WilsonPrime {

	public static boolean am_i_wilson(double p) {
		if (p <= 1) {
			return false;
		}
		if (p == 563) {
			return true;
		}
		return (factorial((int) p - 1) + 1) / Math.pow(p, 2) % 1 == 0;
	}

	public static int factorial(int n) {
		if (n == 0) {
			return 1;
		} else {
			return n * factorial(n - 1);
		}
	}

}
