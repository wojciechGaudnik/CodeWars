package scrabble_score.kyu7;

import java.util.HashMap;

public class Kata{

	public static int scrabbleScore(String word) {
		var map = new HashMap<String, Integer>();
		map.put("aeioulnrst", 1);
		map.put("dg", 2);
		map.put("bcmp", 3);
		map.put("fhvwy", 4);
		map.put("k", 5);
		map.put("jx", 8);
		map.put("qz", 10);
		map.put(" ", 0);
		return word
				.chars()
				.mapToObj(c -> (char) c)
				.map(Character::toLowerCase)
				.mapToInt(
						c -> map
								.get(map.keySet()
										.stream()
										.filter(k -> k.contains(c.toString()))
										.findFirst().orElse(" ")))
				.sum();
	}

}