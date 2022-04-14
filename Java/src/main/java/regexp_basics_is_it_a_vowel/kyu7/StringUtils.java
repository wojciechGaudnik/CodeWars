package regexp_basics_is_it_a_vowel.kyu7;

import java.util.Arrays;
import java.util.LinkedList;

public class StringUtils {

	public static boolean isVowel(String s) {
		var vowels = new LinkedList<String>() {{
			addAll(Arrays.asList("a", "e", "i", "o", "u"));
		}};
		if (vowels.contains(s.toLowerCase())) {
			return true;
		}
		return false;
	}
}
