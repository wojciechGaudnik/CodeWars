package basic_sequence_practice.kyu7;

import java.util.ArrayList;

public class SequenceSum {

	public static int[] sumOfN(int n) {
		var list = new ArrayList<Integer>();
		list.add(0);
		var minus = n <= 0;
		var sum = 0;
		n = Math.abs(n);
		for (var last = 1; last <= n; last++) {
			sum += last;
			list.add(sum);
		}
		if (minus) {
			return list.stream().map(e -> -e).mapToInt(Integer::intValue).toArray();
		}
		return list.stream().mapToInt(Integer::intValue).toArray();
	}
}
   
