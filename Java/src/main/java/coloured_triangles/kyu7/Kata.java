package coloured_triangles.kyu7;

import java.util.HashMap;

public class Kata {
	public static void main(String[] args) {
		System.out.println(triangle("GB"));
	}

	public static char triangle(String row) {
		var map = new HashMap<String, String>() {{
			put("GG", "G");
			put("BB", "B");
			put("RR", "R");
			put("BG", "R");
			put("GB", "R");
			put("RG", "B");
			put("GR", "B");
			put("BR", "G");
			put("RB", "G");
		}};
		while (row.length() > 1) {
			var next = new StringBuilder();
			for (var i = 0; i < row.length() - 1; i++) {
				next.append(map.get(String.valueOf(row.charAt(i)) + row.charAt(i + 1)));
			}
			row = next.toString();
		}
		return row.charAt(0);
	}
}
