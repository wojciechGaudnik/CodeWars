package MergeSortedArrays;

import java.util.Arrays;
import java.util.stream.Stream;

import static java.util.stream.IntStream.concat;
import static java.util.stream.IntStream.of;

public class Kata {

	public static int[] mergeArrays(int[] first, int[] second) {
		return Stream.of(Arrays.stream(first), Arrays.stream(second))
				.flatMapToInt(i -> i)
				.distinct()
				.sorted()
				.toArray();
	}

	public static int[] mergeArrays2(int[] a, int[] b) {
		return concat(of(a), of(b)).sorted().distinct().toArray();
	}
}
