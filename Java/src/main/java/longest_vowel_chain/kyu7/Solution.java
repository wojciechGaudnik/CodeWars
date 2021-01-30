package longest_vowel_chain.kyu7;

import java.util.regex.Pattern;

public class Solution {
	public static int solve(String s) {
		var pattern = Pattern.compile("[aeiou]+");
		var matcher = pattern.matcher(s);
		var answer = 0;
		while (matcher.find()) {
			if (matcher.group().length() > answer) {
				answer = matcher.group().length();
			}
		}
		return answer;
	}
}

