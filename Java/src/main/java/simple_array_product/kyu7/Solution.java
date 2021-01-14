package simple_array_product.kyu7;

import java.util.Arrays;

public class Solution {

	public static int solve(int [][] arr){
		for (var one : arr) {
			Arrays.sort(one);
		}
		Arrays.sort(arr, (a, b) -> a[0] > b[0] ? 1: ((a[a.length - 1] == b[b.length-1])? 0 :-1));
		var mySwitch = 0;
		var maxSwitch = (int)Math.pow(2, arr.length) + 1;
		var answer = 1;
		var maxAnswer = Integer.MIN_VALUE;
		while (mySwitch <= maxSwitch) {
			var mySwitchStr = new StringBuilder(Integer.toBinaryString(mySwitch)).reverse();
			for (var i = 0; i < arr.length; i++) {
				if (i < mySwitchStr.length()) {
					if (mySwitchStr.charAt(i) == '0') {
						answer *= arr[i][0];
					} else {
						answer *= arr[i][arr[i].length - 1];
					}
				} else {
					answer *= arr[i][0];
				}
			}
			if (maxAnswer < answer) {
				maxAnswer = answer;
			}
			answer = 1;
			mySwitch++;

		}
		return maxAnswer;
	}
}
