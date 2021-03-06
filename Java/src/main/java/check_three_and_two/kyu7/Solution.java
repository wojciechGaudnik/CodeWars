package check_three_and_two.kyu7;

import java.nio.CharBuffer;
import java.util.function.Function;
import java.util.stream.Collectors;

public class Solution {

	public boolean checkThreeAndTwo(char[] chars) {
		var mapCharAndCount = CharBuffer.wrap(chars).chars().boxed().collect(Collectors.groupingBy(Function.identity(), Collectors.counting()));
		return mapCharAndCount.size() == 2 && mapCharAndCount.containsValue(2L);
	}
}
