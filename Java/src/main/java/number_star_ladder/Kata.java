package number_star_ladder;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Kata {

	public static String pattern1(int n) {
		return ("1\n" + IntStream.range(2, n + 1).mapToObj(c -> "1" + "*".repeat(c - 1) + c + "\n").collect(Collectors.joining(""))).trim();
	}

	public static String pattern(int n) {
		var answer = new StringBuilder("1\n");
		for (var i = 2; i <= n; i++) {
			answer
					.append("1")
					.append("*".repeat(i - 1))
					.append(i)
					.append("\n");
		}
		return answer.toString().trim();
	}

}