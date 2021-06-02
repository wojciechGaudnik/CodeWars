package show_multiples_of_2_numbers_within_a_range.kyu7;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Solution {

	public static List<Integer> findMultiples1(int s1, int s2, int s3) {
		List<Integer> arr = new ArrayList<Integer>();
		for (int i = s1; i * s1 < s3; i++) {
			if ((s1 * i) % s2 == 0) {
				arr.add(s1 * i);
			}
		}
		for (int i = s2; i * s2 < s3; i++) {
			if ((s2 * i) % s1 == 0) {
				arr.add(s2 * i);
			}
		}
		return arr.stream().distinct().filter(i -> i >= s1 * s2).sorted().collect(Collectors.toList());
	}


	public static List<Integer> findMultiples(int s1, int s2, int s3) {
		List<Integer> arr = new ArrayList<Integer>();
		for (var i = 1; i < s3; i++) {
			if (i % s1 == 0 && i % s2 == 0) {
				arr.add(i);
			}
		}
		return arr;
	}
}
