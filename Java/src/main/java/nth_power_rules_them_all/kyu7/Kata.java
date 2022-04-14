package nth_power_rules_them_all.kyu7;

import java.util.Arrays;

public class Kata {

	public static int modifiedSum(int[] array, int p) {
		return
				Arrays.stream(array).map(i -> (int) Math.pow(i, p)).sum() -
						Arrays.stream(array).sum();
	}
}
