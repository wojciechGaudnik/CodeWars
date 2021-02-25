package is_it_negative_zero.kyu7;

public class NegativeZeroValidator {
	public static boolean isNegativeZero(float n) {
		return String.valueOf(n).equals("-0.0");
	}
}
