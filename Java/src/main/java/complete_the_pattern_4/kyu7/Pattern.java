package complete_the_pattern_4.kyu7;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Pattern {
	public static String pattern(int n) {
		if (n > 0) {
			var answer = new StringBuffer();
			for (var o = 1; o <= n; o++) {
				answer.append(IntStream.range(o, n + 1).mapToObj(String::valueOf).collect(Collectors.joining())).append("\n");
			}
			return answer.toString().trim();
		}
		return "";
	}

}
