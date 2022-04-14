package lost_number_in_number_sequence.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Kata {

	public static void main(String[] args) {
		for (var i = 0; i < 1000000000; i++) {
			System.out.println(findDeletedNumber(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9}, new int[]{1, 9, 7, 4, 6, 2, 3, 8}));
		}

	}

	public static int findDeletedNumber(int[] arr, int[] mixedArr) {
		if (arr.length == mixedArr.length) {
			return 0;
		}
		var set = Arrays.stream(mixedArr).boxed().collect(Collectors.toSet());
		for (var one : arr) {
			if (!set.contains(one)) {
				return one;
			}
		}
		return 0;
	}
}
