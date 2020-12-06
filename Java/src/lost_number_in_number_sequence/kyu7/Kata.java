package lost_number_in_number_sequence.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Kata {

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
