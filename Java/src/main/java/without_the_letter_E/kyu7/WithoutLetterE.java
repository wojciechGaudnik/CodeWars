package without_the_letter_E.kyu7;

import java.util.Locale;

class WithoutLetterE {
	public static String findE(String str) {
		if (str == null || str.isEmpty()) {
			return str;
		}
		var answer = str.toLowerCase(Locale.ROOT).chars().filter(c -> c == 'e').count();
		if (answer == 0) {
			return "There is no \"e\".";
		}
		return String.valueOf(answer);
	}
}
