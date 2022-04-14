package reverse_a_number.kyu7;

public class ReverseNumber {

	public static int reverse(int number) {
		var minus = number < 0;
		var reversedNumber = Integer.valueOf(new StringBuilder(String.valueOf(Math.abs(number))).reverse().toString());
		return (minus) ? -reversedNumber : reversedNumber;
	}
}
