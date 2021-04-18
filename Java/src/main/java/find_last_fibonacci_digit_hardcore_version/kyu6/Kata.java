package find_last_fibonacci_digit_hardcore_version.kyu6;

public class Kata {

	static int lastFibDigit(int n) {
		n--;
		var lastDig = "112358314594370774156178538190998752796516730336954932572910";
		n %= lastDig.length();
		return Integer.parseInt(String.valueOf(lastDig.charAt(n)));
	}

}
