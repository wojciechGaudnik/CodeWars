package composing_squared_strings.kyu7;

public class Composing {

	public static String compose(String s1, String s2) {
		var answer = new StringBuilder();
		var s1s = s1.split("\n");
		var s2s = s2.split("\n");
		for (int i = 0, j = s2s.length - 1; i < s1s.length; i++, j--) {
			answer.append(s1s[i], 0, i + 1).append(s2s[j], 0, j + 1).append("\n");
		}
		return answer.substring(0, answer.length() - 1);
	}
}
