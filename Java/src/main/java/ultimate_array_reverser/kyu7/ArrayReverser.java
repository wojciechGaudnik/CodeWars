package ultimate_array_reverser.kyu7;

import java.util.Arrays;

public class ArrayReverser {
	public static String[] reverse(String[] a) {
		var stringBuilder = new StringBuilder(Arrays.stream(a).reduce("", (s, l) -> s + l)).reverse();
		var answer = new String[a.length];
		var start = 0;
		for (var i = 0; i < a.length; i++) {
			answer[i] = stringBuilder.substring(start, start + a[i].length());
			start += a[i].length();
		}
		return answer;
	}
}
