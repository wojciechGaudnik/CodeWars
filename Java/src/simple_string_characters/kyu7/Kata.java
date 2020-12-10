package simple_string_characters.kyu7;

public class Kata {

	public static int[] Solve(String word) {
		var answer = new int[4];
		for (var one : word.toCharArray()) {
			if (Character.isUpperCase(one)) {
				answer[0] += 1;
				continue;
			}
			if (Character.isLowerCase(one)) {
				answer[1] += 1;
				continue;
			}
			if (Character.isDigit(one)) {
				answer[2] += 1;
				continue;
			}
		}
		answer[3] = word.length() - (answer[0] + answer[1] + answer[2]);
		return answer;
	}
}
