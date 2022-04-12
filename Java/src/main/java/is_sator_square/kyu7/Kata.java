package is_sator_square.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;


class Kata {

	public static Boolean isSatorSquare(char[][] tablet) {
		var list0words = Arrays.stream(tablet).map(String::new).collect(Collectors.toList());
		var rotate = rotate(tablet);
		var list1words = Arrays.stream(rotate).map(String::new).collect(Collectors.toList());
		rotate = rotate(rotate);
		var list2words = Arrays.stream(rotate).map(String::new).collect(Collectors.toList());
		rotate = rotate(rotate);
		var list3words = Arrays.stream(rotate).map(String::new).collect(Collectors.toList());
		return list0words.containsAll(list1words) && list1words.containsAll(list2words) && list2words.containsAll(list3words) && list3words.containsAll(list0words);
	}

	private static char[][] copy(char[][] array) {
		var copy = new char[array.length][];
		for (var y = 0; y < array.length; y++) {
			copy[y] = new char[array.length];
			System.arraycopy(array[y], 0, copy[y], 0, array.length);
		}
		return copy;
	}

	private static char[][] rotate(char[][] array) {
		var copy = copy(array);
		for (int y1 = 0; y1 < array.length; y1++) {
			for (int y2 = array.length - 1, x2 = 0; y2 >= 0; y2--, x2++) {
				copy[y2][y1] = array[y1][x2];
			}
		}
		return copy;
	}

}
