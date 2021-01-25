package max_diff_easy.kyu7;

import java.util.Arrays;

public class Kata {
	static int maxDiff(int[] lst) {
		if (lst.length < 2) {
			return 0;
		}
		Arrays.sort(lst);
		return lst[lst.length- 1] - lst[0];
	}
}
