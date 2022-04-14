package simple_string_reversal.kyu7;

public class Solution {

	public static String solve(String s) {
		var answer = s.toCharArray();
		var i = 0;
		var j = s.length() - 1;
		while (i <= j) {
			if (answer[i] != ' ' && answer[j] != ' ') {
				var buff = answer[i];
				answer[i] = answer[j];
				answer[j] = buff;
				i++;
				j--;
			} else if (answer[i] == ' ') {
				i++;
			} else {
				j--;
			}
		}
		return new String(answer);
	}
}
