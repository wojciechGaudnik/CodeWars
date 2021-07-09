package the_speed_of_letters.kyu7;

import java.util.ArrayList;
import java.util.stream.Collectors;

public class Kata {

	public static String speedify(final String input) {
		var answer = new ArrayList<Character>();
		for (var i = 0; i < input.length(); i++) {
			var index = input.charAt(i) - 65;
			while (true) {
				try {
					answer.set(i + index, input.charAt(i));
				} catch (IndexOutOfBoundsException e) {
					answer.add(' ');
					continue;
				}
				break;
			}
		}
		return answer.stream().map(String::valueOf).collect(Collectors.joining());
	}
}
