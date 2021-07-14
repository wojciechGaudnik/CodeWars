package thinking_testing_something_capitalized.kyu7;

public class ThinkingAndTesting {
	public static String testSomethingCapitalized(String s) {
		var answer = new StringBuilder();
		if (s.equals("")) {
			return "";
		}
		for (var one : s.split(" ")) {
			if (one.length() < 2) {
				answer.append(Character.toUpperCase(one.charAt(0))).append(" ");
			} else {
				answer.append(one, 0, one.length() - 1).append(Character.toUpperCase(one.charAt(one.length() - 1))).append(" ");
			}
		}
		return answer.substring(0, answer.length() - 1);
	}
}
