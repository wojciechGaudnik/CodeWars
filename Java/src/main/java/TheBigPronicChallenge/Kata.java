package TheBigPronicChallenge;

public class Kata {

	public static boolean isPronic(long n) {
		long nn = (long) Math.sqrt(n);
		return n == (nn * (nn + 1));
	}

}
