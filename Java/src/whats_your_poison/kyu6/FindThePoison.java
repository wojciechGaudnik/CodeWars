package whats_your_poison.kyu6;

import java.util.Arrays;
import java.util.Collections;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class FindThePoison {
	public int find(int[] rats) {
		var ratsList = Arrays.stream(rats)
				.boxed()
				.collect(Collectors.toList());
		var test = IntStream.range(0, 10)
				.boxed()
				.sorted(Collections.reverseOrder())
				.map(i -> (ratsList.contains(i))?"1":"0")
				.collect(Collectors.joining());
		return Integer.parseInt(test, 2);
	}
}
   
