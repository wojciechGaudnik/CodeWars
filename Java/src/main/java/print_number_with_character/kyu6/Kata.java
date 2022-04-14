package print_number_with_character.kyu6;

import java.util.HashMap;

class Kata {
	private static final String[] zero = new String[]{
			" XXXX ",
			"XX  XX",
			"XX  XX",
			"XX  XX",
			"XX  XX",
			" XXXX "
	};
	private static final String[] one = new String[]{
			"  XX  ",
			" XXX  ",
			"X XX  ",
			"  XX  ",
			"  XX  ",
			"XXXXXX"
	};

	private static final String[] two = new String[]{
			" XXXX ",
			"XX  XX",
			"   XX ",
			"  XX  ",
			" XX   ",
			"XXXXXX"
	};

	private static final String[] three = new String[]{
			" XXXX ",
			"XX  XX",
			"   XX ",
			"   XX ",
			"XX  XX",
			" XXXX "
	};

	private static final String[] four = new String[]{
			"XX  XX",
			"XX  XX",
			"XX  XX",
			" XXXXX",
			"    XX",
			"    XX"
	};

	private static final String[] five = new String[]{
			"XXXXXX",
			"XX    ",
			"XXXXX ",
			"    XX",
			"    XX",
			"XXXXX "
	};


	private static final String[] six = new String[]{
			"   XX ",
			"  XX  ",
			" XXXX ",
			"XX  XX",
			"XX  XX",
			" XXXX "

	};


	private static final String[] seven = new String[]{
			"XXXXXX",
			"XX  XX",
			"   XX ",
			"  XX  ",
			" XX   ",
			" XX   "
	};

	private static final String[] eight = new String[]{
			" XXXX ",
			"XX  XX",
			" XXXX ",
			" XXXX ",
			"XX  XX",
			" XXXX "
	};

	private static final String[] nine = new String[]{
			" XXXX ",
			"XX  XX",
			"XX  XX",
			" XXXX ",
			"  XX  ",
			" XX   "

	};

	public static String printNumber(int num, char ch) {
		var map = new HashMap<Integer, String[]>();
		map.put(0, zero);
		map.put(1, one);
		map.put(2, two);
		map.put(3, three);
		map.put(4, four);
		map.put(5, five);
		map.put(6, six);
		map.put(7, seven);
		map.put(8, eight);
		map.put(9, nine);
		var answer = new StringBuilder();
		answer.append("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n");
		answer.append("X                                      X\n");
		var first = (num / 10000) % 10;
		var second = (num / 1000) % 10;
		var third = (num / 100) % 10;
		var fourth = (num / 10) % 10;
		var fifth = (num / 1) % 10;
		var digits = new Integer[]{first, second, third, fourth, fifth};
		for (var row = 0; row < 6; row++) {
			answer.append("X  ");
			for (var j = 0; j < 5; j++) {
				answer.append(map.get(digits[j])[row]).append(" ");
			}
			answer.append(" X\n");
		}
		answer.append("X                                      X\n");
		answer.append("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
		return answer.toString().replace("X", String.valueOf(ch));
	}
}
