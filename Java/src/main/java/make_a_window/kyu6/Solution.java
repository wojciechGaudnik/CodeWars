package make_a_window.kyu6;

public class Solution {
	public static String makeAWindow(int num) {
		var answer = new StringBuilder();
		var topAndBottom = "-".repeat(num * 2 + 3);
		var middle = "|" + "-".repeat(num) + "+" + "-".repeat(num) + "|\n";
		var between = "|" + ".".repeat(num) + "|" + ".".repeat(num) + "|\n";
		return answer
				.append(topAndBottom).append("\n")
				.append(between.repeat(num))
				.append(middle)
				.append(between.repeat(num))
				.append(topAndBottom).toString();
	}
}
