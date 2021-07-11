package most_valuable_character.kyu7;

import java.util.Arrays;

public class Solution {
	public static char solve(String s) {
		String answer = String.valueOf(s.charAt(0));
		var max = 0;
		for (var i = 0; i < s.length(); i++) {
			var difference = s.lastIndexOf(s.charAt(i)) - i;
			if (max < difference) {
				max = difference;
				answer = String.valueOf(s.charAt(i));
			} else if (max == difference) {
				answer += String.valueOf(s.charAt(i));
			}
		}
		var sorted = answer.toCharArray();
		Arrays.sort(sorted);
		return sorted[0];
	}
}
