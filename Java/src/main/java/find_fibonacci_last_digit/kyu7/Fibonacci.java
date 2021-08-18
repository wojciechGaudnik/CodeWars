package find_fibonacci_last_digit.kyu7;

public class Fibonacci {
	public static int getFibNumb(int n) {
		n--;
		var lastDig = "112358314594370774156178538190998752796516730336954932572910";
		n %= lastDig.length();
		return Integer.parseInt(String.valueOf(lastDig.charAt(n)));
	}
}
