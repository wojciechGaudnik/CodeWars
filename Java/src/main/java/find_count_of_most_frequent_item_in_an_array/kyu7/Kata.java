package find_count_of_most_frequent_item_in_an_array.kyu7;

import java.util.Arrays;
import java.util.function.Function;
import java.util.stream.Collectors;

public class Kata {
	public static void main(String[] args) {
		System.out.println(mostFrequentItemCount(new int[] {3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3}));
	}

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
