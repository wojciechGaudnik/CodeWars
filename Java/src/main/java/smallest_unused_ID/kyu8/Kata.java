package smallest_unused_ID.kyu8;

import java.util.Arrays;

public class Kata {

	public static int nextId(int[] ids) {
		for (var i = 0; ; i++) {
			int finalI = i;
			if (Arrays.stream(ids).noneMatch(e -> e == finalI)) {
				return i;
			}
		}
	}
}
