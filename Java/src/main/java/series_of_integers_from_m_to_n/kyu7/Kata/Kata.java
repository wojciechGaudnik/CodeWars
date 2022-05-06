package series_of_integers_from_m_to_n.kyu7.Kata;

import java.util.stream.IntStream;

public class Kata {

	public static int[] generateIntegers(final int m, final int n) {
		return IntStream.range(m, n + 1).toArray();
	}

}