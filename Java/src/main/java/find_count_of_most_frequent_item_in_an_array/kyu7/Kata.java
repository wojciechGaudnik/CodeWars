package find_count_of_most_frequent_item_in_an_array.kyu7;

import java.util.Arrays;
import java.util.function.Function;
import java.util.stream.Collectors;

public class Kata {

	public static int mostFrequentItemCount(int[] collection) {
		return (int) Arrays.stream(collection)
				.boxed()
				.collect(Collectors.groupingBy(Function.identity(), Collectors.counting()))
				.values()
				.stream()
				.mapToLong(i -> i)
				.max()
				.orElse(0);
	}
}
