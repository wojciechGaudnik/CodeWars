package the_poet_and_the_pendulum.kyu7;

import java.util.Arrays;
import java.util.LinkedList;

public class Poet {

	public static int[] pendulum(final int[] values) {
		var list = new LinkedList<Integer>();
		Arrays.sort(values);
		for (int i = 0; i < values.length; i++) {
			if (i % 2 == 0) list.add(0, values[i]);
			else list.add( values[i]);
		}
		return list.stream().mapToInt(i -> i).toArray();
	}
}
