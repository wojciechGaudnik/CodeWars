package max_diff_easy.kyu7;

import java.util.Arrays;

public class Kata {
	public static void main(String[] args) {
		System.out.println(maxDiff(new int[]{ 1, 2, 3, 4, -5, 5, 4 }));
	}

	public static int maxDiff(int[] lst) {
		if (lst.length < 2) {
			return 0;
		}
		Arrays.sort(lst);
		return lst[lst.length- 1] - lst[0];
	}
}
