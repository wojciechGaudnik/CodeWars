package balanced_number_special_numbers_series1.kyu7;

public class Solution {

	public static String balancedNum(long number) {
		if (number < 100) {
			return "Balanced";
		}
		var size = String.valueOf(number).length();
		var left = "";
		var right = "";
		if (size % 2 == 0) {
			left = String.valueOf(number).substring(0, (size / 2) - 1);
			right = String.valueOf(number).substring((size / 2) + 1);
			return (getSum(left.toCharArray()) == getSum(right.toCharArray())) ? "Balanced" : "Not Balanced";
		} else {
			left = String.valueOf(number).substring(0, (size / 2));
			right = String.valueOf(number).substring((size / 2) + 1);
			return (getSum(left.toCharArray()) == getSum(right.toCharArray())) ? "Balanced" : "Not Balanced";
		}
	}

	private static int getSum(char[] numberChars) {
		var sum = 0;
		for (var one : numberChars) {
			sum += Character.getNumericValue(one);
		}
		return sum;
	}
}
