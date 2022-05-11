package series_of_integers_from_0_to_n.kyu7;

import java.util.stream.IntStream;

public class Kata {
	public static int[] generateIntegers(int n){
		return IntStream.range(0, n + 1).toArray();
	}
}