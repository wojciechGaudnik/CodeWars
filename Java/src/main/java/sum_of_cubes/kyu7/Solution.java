package sum_of_cubes.kyu7;

public class Solution {
	public static long sumCubes(int n) {
		var answer = 0L;
		while (n-- > 0) {
			answer += Math.pow(n + 1D, 3D);
		}
		return answer;
	}

}