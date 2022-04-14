package bus_mastering_who_is_the_most_prioritary.kyu7;

public class BusMastering {
	public static String arbitrate(String input, int n) {
		var answer = new StringBuilder();
		if (!input.contains("1")) {
			return input;
		}
		var test = true;
		for (var i = 0; i < input.length(); i++) {
			if (test && input.charAt(i) == '1') {
				answer.append(input.charAt(i));
				test = false;
			} else {
				answer.append('0');
			}
		}
		return answer.toString();
	}
}
