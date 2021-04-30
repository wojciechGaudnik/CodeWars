package find_the_integral.kyu8;

public class Kata {
	public static void main(String[] args) {
		System.out.println(integrate(90, 2));
	}

	public static String integrate(int coefficient, int exponent) {
		return (coefficient / ++exponent) + "x^" + exponent;
	}
}
