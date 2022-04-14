package array_leaders_array_series_3.kyu7;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class Solution {

	public static List arrayLeaders(int[] numbers) {
		var sumAll = Arrays.stream(numbers).sum();
		var answer = new LinkedList<>();
		for (var one : numbers) {
			sumAll -= one;
			if (one > sumAll) {
				answer.add(one);
			}
		}
		return answer;
	}
}
   
