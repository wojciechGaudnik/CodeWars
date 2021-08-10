package numbers_which_sum_of_powers_of_its_digits_is_the_same_number.kyu7;

import java.util.LinkedList;

public class Sumpowdig {

	public static Long[] eqSumPowDig(long hmax, int exp) {
		var answer = new LinkedList<Long>();
		for (long i = 2; i <= hmax; i++) {
			if (strToSumPow(i, exp) == i) {
				answer.add(i);
			}
		}
		return answer.toArray(new Long[0]);
	}

	private static long strToSumPow(long number, int exp) {
		var strNumber = String.valueOf(number);
		var answer = 0;
		for (var one : strNumber.toCharArray()) {
			answer += Math.pow(Character.getNumericValue(one), exp);
		}
		return answer;
	}

}
