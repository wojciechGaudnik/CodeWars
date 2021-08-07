package sum_of_differences_between_products_and_LCMs.kyu7;

import java.util.Arrays;

public class Solution {
	public static int sumDifferencesBetweenProductsAndLCMs(final int[][] pairs) {
		return Math.toIntExact(Arrays.stream(pairs).mapToInt(p -> (p[0] * p[1]) - findLCM(p[0], p[1])).sum());
	}

	public static int findGCF(int num1, int num2) {
		if (num2 == 0) {
			return num1;
		} else {
			return findGCF(num2, num1 % num2);
		}
	}

	public static int findLCM(int num1, int num2) {
		if (num1 == 0 || num2 == 0) {
			return 0;
		} else {
			var gcd = findGCF(num1, num2);
			return (num1 * num2) / gcd;
		}
	}
}
