package reverse_the_bits_in_an_integer.kyu7;

public class BitsOfInteger {

	public static int reverse_bits(int n) {
		return Integer.parseInt(new StringBuilder(Integer.toBinaryString(n)).reverse().toString(), 2);
	}
}
