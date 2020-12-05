package sort_out_the_men_from_boys.kyu7;

import java.util.Arrays;
import java.util.LinkedList;

public class Kata {

	public static int[] menFromBoys(final int[] values) {
		var men = new LinkedList<Integer>();
		var boys = new LinkedList<Integer>();
		Arrays.sort(values);
		for (int one : Arrays.stream(values).distinct().toArray()) {
			if (one % 2 == 0) {
				men.add(one);
			} else {
				boys.addFirst(one);
			}
		}
		men.addAll(boys);
		return men.stream().mapToInt(Integer::intValue).toArray();
	}
}
