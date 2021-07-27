package common_substrings.kyu7;

import java.util.Locale;

public class Kata {

	public static boolean SubstringTest(String str1, String str2) {
		str1 = str1.toLowerCase(Locale.ROOT);
		str2 = str2.toLowerCase(Locale.ROOT);
		for (var i = 0; i < str1.length() - 1; i++) {
			if (str2.contains(str1.substring(i, i + 2))) {
				return true;
			}
		}
		return false;
	}
}
