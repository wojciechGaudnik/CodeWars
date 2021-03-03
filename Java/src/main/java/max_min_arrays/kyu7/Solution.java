package max_min_arrays.kyu7;

import java.util.Arrays;

public class Solution {

	public static int[] solve (int[] arr){
		Arrays.sort(arr);
		var answer = new int[arr.length];
		var x = 0;
		for (int i = 0, j = arr.length - 1; i <= j; i++, j--) {
			answer[x++] = arr[j];
			if (x < arr.length) {
				answer[x++] = arr[i];
			}
		}
		return answer;
	}
}
