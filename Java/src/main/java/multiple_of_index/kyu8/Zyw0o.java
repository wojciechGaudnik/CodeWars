package multiple_of_index.kyu8;

import java.util.LinkedList;

class ZywOo {
	public static int[] multipleOfIndex(int[] array) {
		var answer = new LinkedList<>();
		for (var i = 1; i < array.length; i++) {
			if (array[i] % i == 0) {
				answer.add(array[i]);
			}
		}
		return answer.stream().mapToInt(e -> (int)e).toArray();
	}
}
