package how_many_days_are_we_represented_in_a_foreign_country.kyu7;

import java.util.Arrays;
import java.util.Collection;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Representation {

	public static int daysRepresented(int[][] trips) {
		return Arrays.stream(trips).map(trip -> IntStream.range(trip[0], trip[1] + 1).boxed().collect(Collectors.toSet()))
				.flatMap(Collection::stream)
				.collect(Collectors.toSet())
				.stream().mapToInt(e -> 1)
				.sum();
	}
}
