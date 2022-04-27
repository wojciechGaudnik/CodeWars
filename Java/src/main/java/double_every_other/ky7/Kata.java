package double_every_other.ky7;

import java.util.stream.IntStream;

public class Kata {

	public static int[] doubleEveryOther(int[] a) {
		return IntStream.range(0, a.length).map(i -> (i % 2 == 1) ? a[i] * 2 : a[i]).toArray();
	}

}