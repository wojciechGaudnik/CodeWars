package complete_the_pattern_2.Kyu7;

import java.util.Collections;
import java.util.stream.IntStream;

public class CompleteThePattern {

	public static String pattern(int n) {
		if (n <= 0) {
			return "";
		}
		var answer = new StringBuilder();
		var i = n - 1;
		while (i >= 0) {
			answer.append(IntStream.range(n - i--, n + 1)
							.boxed()
							.sorted(Collections.reverseOrder())
							.map(String::valueOf).reduce((a, b) -> a + b).orElseGet(() -> ""))
					.append("\n");
		}
		return answer.substring(0, answer.length() - 1);
	}
}
