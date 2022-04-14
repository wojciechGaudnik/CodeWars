package insert_dashes.kyu7;

import java.util.ArrayList;

public class Solution {

	public static String insertDash(int num) {
		StringBuilder answer = new StringBuilder();
		var numString = String.valueOf(num);
		var odds = new ArrayList<Character>() {{
			add('1');
			add('3');
			add('5');
			add('7');
			add('9');
		}};
		for (var i = 0; i < numString.length() - 1; i++) {
			if (odds.contains(numString.charAt(i)) && odds.contains(numString.charAt(i + 1))) {
				answer.append(numString.charAt(i));
				answer.append("-");
			} else {
				answer.append(numString.charAt(i));
			}
		}
		answer.append(numString.charAt(numString.length() - 1));
		return answer.toString();
	}
}
