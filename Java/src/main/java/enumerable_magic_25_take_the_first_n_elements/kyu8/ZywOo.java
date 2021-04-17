package enumerable_magic_25_take_the_first_n_elements.kyu8;

import java.util.Arrays;

public class ZywOo {
	public static int[] take(int[] arr, int n) {
		if (arr.length == 0) {
			return new int[0];
		}
		return Arrays.copyOfRange(arr, 0, Math.min(n, arr.length));
	}
}
