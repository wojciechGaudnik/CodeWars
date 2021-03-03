package letterbox_paint_squad.kyu7;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Dinglemouse {

	public static int[] paintLetterboxes(final int start, final int end) {
		var answer = new int[10];
		for (var one : IntStream.range(start, end + 1).mapToObj(String::valueOf).collect(Collectors.joining("")).toCharArray()) {
			answer[one - 48]++;
		}
		return answer;
	}
}
