package sum_of_array_singles.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Solution {

	public static void main(String[] args) {

	}

	public static int repeats(int [] arr){
		var list = Arrays.stream(arr).boxed().collect(Collectors.toList());
		var answer = 0;
		for (var one : arr) {
			if (list.stream().filter(e -> e.equals(one)).count() == 1) {
				answer += one;
			}
		}
		return answer;
	}
}
