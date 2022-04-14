package Four_Seven.kyu7;

import java.util.HashMap;

public class Kata {
	public static int fourSeven(int n) {
		var map = new HashMap<Integer, Integer>();
		map.put(4, 7);
		map.put(7, 4);
		return map.getOrDefault(n, 0);
	}
}
