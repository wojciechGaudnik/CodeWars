package to_leet_speak.kyu7;

import java.util.HashMap;
import java.util.stream.Collector;

public class Kata {

	static String toLeetSpeak(final String speak) {
		var alphabet = new HashMap<>() {{
			put('A', '@');
			put('B', '8');
			put('C', '(');
			put('D', 'D');
			put('E', '3');
			put('F', 'F');
			put('G', '6');
			put('H', '#');
			put('I', '!');
			put('J', 'J');
			put('K', 'K');
			put('L', '1');
			put('M', 'M');
			put('N', 'N');
			put('O', '0');
			put('P', 'P');
			put('Q', 'Q');
			put('R', 'R');
			put('S', '$');
			put('T', '7');
			put('U', 'U');
			put('V', 'V');
			put('W', 'W');
			put('X', 'X');
			put('Y', 'Y');
			put('Z', '2');
		}};
		return speak.chars().mapToObj(c -> (char) c).map(c -> alphabet.getOrDefault(c, c)).collect(Collector.of(StringBuilder::new, StringBuilder::append, StringBuilder::append, StringBuilder::toString));
	}
}
