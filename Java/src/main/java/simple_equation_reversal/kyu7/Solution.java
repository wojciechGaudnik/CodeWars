package simple_equation_reversal.kyu7;

import java.util.regex.Pattern;

public class Solution {
	public static String solve(String eq) {
		var matcher = Pattern.compile("[a-z]|[+\\-*\\/]|\\d*").matcher(eq);
		var answer = new StringBuilder();
		while (matcher.find()) {
			answer.insert(0, matcher.group());
		}
		return answer.toString();
	}
}
