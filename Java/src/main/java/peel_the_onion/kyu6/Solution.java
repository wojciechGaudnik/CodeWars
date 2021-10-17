package peel_the_onion.kyu6;

import java.util.ArrayList;
import java.util.Collections;

class Solution {

	public static int[] peelTheOnion(int s, int d) {
		var answer = new ArrayList<Double>();
		if (s % 2 == 0) {
			var number = Math.pow(2, d);
			answer.add(number);
			var i = 4;
			while (i <= s) {
				var maxBuff = Math.pow(i, d) - answer.stream().reduce(0D, Double::sum);
				answer.add(maxBuff);
				i += 2;
			}
		} else {
			var number = 1D;
			answer.add(number);
			var i = 3;
			while (i <= s) {
				var maxBuff = Math.pow(i, d) - answer.stream().reduce(0D, Double::sum);
				answer.add(maxBuff);
				i += 2;
			}
		}
		Collections.reverse(answer);
		return answer.stream().mapToInt(Double::intValue).toArray();
	}
}
