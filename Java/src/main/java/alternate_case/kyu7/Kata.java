package alternate_case.kyu7;

import java.util.stream.Collector;

public class Kata {

	static String alternateCase(final String string) {
		return string.chars()
				.mapToObj(c -> (char) c)
				.map(c -> (Character.isLowerCase(c) ? Character.toUpperCase(c) : Character.toLowerCase((c))))
				.collect(Collector.of(StringBuilder::new, StringBuilder::append, StringBuilder::append, StringBuilder::toString));
//		Collectors.joining("")
	}
}
