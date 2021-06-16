package sort_an_array_by_value_and_index.kyu7;

import java.util.Comparator;
import java.util.stream.IntStream;

public class Kata {



	public static int[] sortByValueAndIndex(int[] array){
		return IntStream.range(0, array.length)
				.mapToObj(i -> new Pair(i, array))
				.sorted(Comparator.comparing(Pair::getCalculated))
				.mapToInt(Pair::getOriginal)
				.toArray();
	}

}

class Pair {
	private final int calculated;
	private final int original;

	public Pair(Integer i, int[] array) {
		this.calculated = (i + 1) * array[i];
		this.original = array[i];
	}

	public Integer getCalculated() {
		return calculated;
	}

	public Integer getOriginal() {
		return original;
	}

}
