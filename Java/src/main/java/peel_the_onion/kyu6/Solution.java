package peel_the_onion.kyu6;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

class Solution {
	public static void main(String[] args) {
//		System.out.println(Arrays.toString(peelTheOnion(5, 4)));
//		System.out.println(Arrays.toString(peelTheOnion(3, 4)));
//		System.out.println(Arrays.toString(peelTheOnion(1, 4)));
//		System.out.println(Arrays.toString(peelTheOnion(5, 3)));
//		System.out.println(Arrays.toString(peelTheOnion(3, 3)));
//		System.out.println(Arrays.toString(peelTheOnion(1, 3)));
//		System.out.println(Arrays.toString(peelTheOnion(5, 2)));
//		System.out.println(Arrays.toString(peelTheOnion(3, 2)));
//		System.out.println(Arrays.toString(peelTheOnion(1, 2)));
//		System.out.println(Arrays.toString(peelTheOnion(5, 1)));
//		System.out.println(Arrays.toString(peelTheOnion(3, 1)));
//		System.out.println(Arrays.toString(peelTheOnion(1, 1)));

		System.out.println(Arrays.toString(peelTheOnion(4, 4)));
		System.out.println(Arrays.toString(peelTheOnion(2, 4)));

		System.out.println(Arrays.toString(peelTheOnion(4, 3)));
		System.out.println(Arrays.toString(peelTheOnion(2, 3)));
	}
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
