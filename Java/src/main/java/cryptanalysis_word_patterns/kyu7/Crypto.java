package cryptanalysis_word_patterns.kyu7;

import java.util.HashMap;

public class Crypto {
	public static String wordPattern(final String word) {
		var map = new HashMap<Character, Integer>();
		var answer = new StringBuilder();
		var index = 0;
		for (var one : word.toCharArray()) {
			if (map.containsKey(Character.toLowerCase(one))) {
				answer.append(map.get(Character.toLowerCase(one))).append(".");
			} else {
				map.put(Character.toLowerCase(one), index);
				answer.append(index++).append(".");
			}

		}
		return answer.deleteCharAt(answer.length() - 1).toString();
	}

}
