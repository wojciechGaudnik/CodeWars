package tidy_number_special_numbers_series9.kyu7;

public class Solution {

	public static boolean tidyNumber(int number) {
		var chars = String.valueOf(number).toCharArray();
		for (var i = 0; i < chars.length - 1; i++) {
			if (chars[i] > chars[i + 1]) {
				return false;
			}
		}
		return true;
	}
}
