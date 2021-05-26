package word_to_initial_number.kyu7;

import java.util.HashMap;

public class Converter {
	public static long convert(String word){
		if (word == null || word.length() == 0) {
			return 0;
		}
		var map = new HashMap<Character, Character>();
		var number = "1023456789";

		var i = 0;
		for (var one : word.toLowerCase().toCharArray()) {
			if (!map.containsKey(one)) {
				map.put(one, number.charAt(i++));
			}
		}
		var answer = new StringBuilder();

		for (var one: word.toLowerCase().toCharArray()) {
			answer.append(map.get(one));
		}
		return Long.parseLong(answer.toString());
	}
}
