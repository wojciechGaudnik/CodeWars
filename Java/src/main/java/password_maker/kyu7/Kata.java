package password_maker.kyu7;

import java.util.Arrays;
import java.util.HashMap;
import java.util.stream.Collectors;

class Kata {

	public static String makePassword(String phrase){
		if (phrase.equals("")) {
			return "";
		}
		var map = new HashMap<Character, Character>();
		map.put('i', '1');
		map.put('I', '1');
		map.put('o', '0');
		map.put('O', '0');
		map.put('s', '5');
		map.put('S', '5');
		return Arrays.stream(phrase.split(" "))
				.map(w -> w.charAt(0))
				.map(c -> map.getOrDefault(c, c))
				.map(String::valueOf)
				.collect(Collectors.joining());
	}
}