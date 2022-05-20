package return_negative.kyu7;

public class Kata {

	public static int makeNegative(final int x) {
		return Math.abs(x) - Math.abs(x) * 2;
	}

}