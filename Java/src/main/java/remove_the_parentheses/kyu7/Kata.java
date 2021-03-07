package remove_the_parentheses.kyu7;

public class Kata {
	public static String removeParentheses(final String str) {
		var answer = str;
		while (answer.contains("(") || answer.contains(")")) {
			answer = answer.replaceAll("\\([^().]*\\)", "");
		}
		return answer;
	}
}
