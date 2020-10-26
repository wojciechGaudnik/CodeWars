package sorted_yes_no_how.kyu7;

import java.util.Arrays;
import java.util.Collections;

public class Solution {

	public static void main(String[] args) {
		System.out.println(isSortedAndHow(new int[]{15, 7, 3, -8}));
		System.out.println(isSortedAndHow(new int[]{1,2,3}));
	}

	public static String isSortedAndHow(int[] array) {
		var copyArray = Arrays.copyOf(array, array.length);
		Arrays.sort(array);
		if (Arrays.equals(copyArray, array)) {
			return "yes, ascending";
		}
		var reversed = Arrays.stream(array).boxed()
				.sorted(Collections.reverseOrder())
				.mapToInt(Integer::intValue).toArray();
		if (Arrays.equals(copyArray, reversed)) {
			return "yes, descending";
		}
		return "no";
	}
}
   
