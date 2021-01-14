package minimum_steps_array_series6.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Kata {

	public static int minimumSteps(int[] numbers, int k) {
		Arrays.sort(numbers);
		if (numbers[0] >= k) return 0;
		var answer = 1;
		var sum = numbers[0] + numbers[1];
		for (var one : Arrays.stream(numbers).skip(2).boxed().collect(Collectors.toList())) {
			if (sum >= k) {
				return answer;
			}
			answer++;
			sum += one;
		}
		return answer;
	}
}
   
