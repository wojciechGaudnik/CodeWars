package regexp_basics_is_it_a_letter.kyu7;

public class StringUtils {

	public static boolean isLetter(String s) {
		if (s.length() != 1) return false;
		return Character.isAlphabetic(s.charAt(0));
	}
}
