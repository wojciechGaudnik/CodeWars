package product_array_array_series5.kyu7;

import java.math.BigInteger;

public class Solution {

	public static long[] productArray(int[] numbers) {
		BigInteger prodAll = BigInteger.ONE;
		for (int number : numbers) {
			prodAll = prodAll.multiply(BigInteger.valueOf(number));
		}
		var answer = new long[numbers.length];
		for (var i = 0; i < numbers.length; i++) {
			answer[i] = prodAll.divide(BigInteger.valueOf(numbers[i])).longValue();
		}
		return answer;
	}
}
   
