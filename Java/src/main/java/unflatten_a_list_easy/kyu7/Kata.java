package unflatten_a_list_easy.kyu7;

import java.util.Arrays;
import java.util.Objects;

class Kata {
	public static Object[] unflatten(int[] flatArray) {
		var answer = new Object[flatArray.length];
		var a = 0;
		for (var i = 0; i < flatArray.length; i++) {
			if (flatArray[i] < 3) {
				answer[a++] = flatArray[i];
			} else {
				var subLength = (i + flatArray[i] >= flatArray.length ? flatArray.length - i : flatArray[i]);
				var buff = new int[subLength];
				System.arraycopy(flatArray, i, buff, 0, subLength);
				answer[a++] = buff;
				i += flatArray[i] - 1;
			}
		}
		return Arrays.stream(answer).filter(Objects::nonNull).toArray();
	}
}
