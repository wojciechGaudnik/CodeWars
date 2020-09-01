package simple_fun_prime_string.kyu6;

import java.util.regex.Pattern;

public class Kata {

	public static boolean primeString(String s) {
		var pattern = Pattern.compile("^(.+?)\\1{1,}$");
		var matcher = pattern.matcher(s);
		return !matcher.find();
	}
}
