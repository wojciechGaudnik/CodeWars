package simple_consecutive_pairs.kyu7;

public class Solution {
	public static int solve(int[] arr) {
		System.out.println("\n");
		var answer = 0;
		for (var i = 1; i < arr.length; i += 2) {
			if (Math.abs(arr[i - 1] - arr[i]) == 1) {
				answer++;
			}
		}
		return answer;
	}
}
