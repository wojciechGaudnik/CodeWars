package find_the_integral.kyu8;

public class Kata {

	public static String integrate(int coefficient, int exponent) {
		return (coefficient / ++exponent) + "x^" + exponent;
	}
}
