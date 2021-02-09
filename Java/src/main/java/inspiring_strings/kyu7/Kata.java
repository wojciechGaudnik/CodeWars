package inspiring_strings.kyu7;

import java.util.Arrays;

public class Kata {

	public static String longestWord(String wordString) {
		return Arrays.stream(wordString.split(" ")).min((w1, w2) -> (w1.length() <= w2.length()) ? 1 : -1).get();
	}
}
