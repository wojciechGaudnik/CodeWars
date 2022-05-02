package sum_of_cubes.kyu7;

import java.math.BigInteger;

public class Solution {
	public static long sumCubes(int n) {
		var answer = 0L;
		while (n-- > 0) {
			answer += Math.pow(n + 1D, 3D);
		}
		return answer;
	}

	public static int sumCubes2(int n) {
		System.out.println(n);
		var answer = 0;
		for (var i = 1; i <= n; i++) {
			answer += Math.pow(i, 3);
		}
		return answer;
	}
}