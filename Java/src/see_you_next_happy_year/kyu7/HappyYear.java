package see_you_next_happy_year.kyu7;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class HappyYear {

	static public int nextHappyYear(int year) {
		return IntStream.range(year + 1, year * 2)
				.filter(y -> String.valueOf(y)
						.chars()
						.boxed()
						.collect(Collectors.toSet())
						.size() == String.valueOf(y).length())
				.findFirst()
				.getAsInt();
	}
}
