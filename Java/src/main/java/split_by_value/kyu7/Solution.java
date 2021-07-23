package split_by_value.kyu7;

import java.util.Arrays;
import java.util.Objects;
import java.util.stream.Collectors;

public class Solution {
	int[] splitByValue(int k, int[] elements) {
		var elementsPost = Arrays.stream(elements).boxed().collect(Collectors.toList());
		var answer = new int[elements.length];
		var currentIndex = 0;
		for (var i = 0; i < elements.length; i++) {
			if (elementsPost.get(i) < k) {
				answer[currentIndex++] = elementsPost.get(i);
				elementsPost.set(i, null);
			}
		}
		for (var one : elementsPost.stream().filter(Objects::nonNull).collect(Collectors.toList())) {
			answer[currentIndex++] = one;
		}
		return answer;
	}
}
