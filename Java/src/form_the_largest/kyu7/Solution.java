package form_the_largest.kyu7;

import java.util.Arrays;

public class Solution {

	public static long maxNumber(long n) {
		var charArray = String.valueOf(n).toCharArray();
		Arrays.sort(charArray);
		return Long.parseLong(new StringBuilder(String.valueOf(charArray)).reverse().toString());
	}
}
