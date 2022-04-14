package thinking_testing_incomplete_string.kyu7;

class ThinkingAndTesting {
	public static String testIncompleteString(String s) {
		var answer = new StringBuilder();
		for (var i = 0; i < s.length() - 1; i += 2) {
			answer.append((char) ((s.charAt(i) + s.charAt(i + 1)) / 2));
		}
		return (s.length() % 2 == 0) ? answer.toString() : answer.toString() + s.charAt(s.length() - 1);
	}
}
