package simple_reversed_parenthesis.kyu6;

public class Solution {

	public static int solve(String s) {
		var answer = 0;
		while (s.length() > 0) {
			while (s.contains("()")) {
				s = s.replaceAll("\\(\\)", "");
			}
			if (s.contains("((")) {
				answer++;
				s = s.replaceFirst("\\(\\(", "");
			} else if (s.contains("))")) {
				answer++;
				s = s.replaceFirst("\\)\\)", "");
			} else if (s.equals(")(")) {
				answer += 2;
				s = "";
			} else if (s.equals("(") || s.equals(")")) {
				return -1;
			}
		}
		return answer;
	}

}
