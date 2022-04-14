package thinking_testing_uniq_or_not_uniq.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Kata {

	public static int[] testit(int[] a, int[] b) {
		var listA = Arrays.stream(a).distinct().boxed().collect(Collectors.toList());
		var listB = Arrays.stream(b).distinct().boxed().collect(Collectors.toList());
		listA.addAll(listB);
		return listA.stream().sorted().mapToInt(Integer::intValue).toArray();
	}

}
