package sorting_the_odd_way.kyu7;

import java.util.Arrays;
import java.util.Comparator;
import java.util.LinkedList;

public class Kata {

	public static Double[] sortItOut(Double[] array) {
		var answer = new LinkedList<Double>();
		Arrays.stream(array).sorted(Comparator.reverseOrder()).forEach(n -> {
			if ((n.intValue() % 2 == 1)) {
				answer.addFirst(n);
			} else {
				answer.addLast(n);
			}
		});
		return answer.toArray(new Double[0]);
	}

}
