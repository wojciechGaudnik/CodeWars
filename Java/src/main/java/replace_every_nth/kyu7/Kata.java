package replace_every_nth.kyu7;

public class Kata {
	public static String replaceNth(String text, int n, char oldValue, char newValue) {
		StringBuilder answer = new StringBuilder();
		var buff = 1;
		for (var one : text.toCharArray()) {
			if (one == oldValue && buff == n) {
				answer.append(newValue);
				buff = 1;
			} else if (one == oldValue) {
				buff++;
				answer.append(one);
			} else {
				answer.append(one);
			}
		}
		return answer.toString();
	}
}
