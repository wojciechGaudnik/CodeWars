package is_n_divisigle_by.kyu7;

public class Divisible {

	public static boolean isDivisible(int... args) {
		var number = args[0];
		try {
			for (var i = 1; i < args.length; i++) {
				if (number % args[i] != 0) {
					return false;
				}
			}

		} catch (ArithmeticException n) {
			return false;
		}
		return true;
	}
}
