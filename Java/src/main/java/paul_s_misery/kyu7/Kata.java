package paul_s_misery.kyu7;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Objects;

public class Kata {

	public static String paul(String[] x) {
		var map = new HashMap<String, Integer>();
		map.put("kata", 5);
		map.put("Petes kata", 10);
		map.put("eating", 1);
		var answer= Arrays.stream(x).mapToInt(e -> map.getOrDefault(e, 0)).filter(Objects::nonNull).sum();
		if (answer > 100) {
			return "Miserable!";
		}
		if (answer >= 70) {
			return "Sad!";
		}
		if (answer >= 40) {
			return "Happy!";
		}
		return "Super happy!";
	}

}