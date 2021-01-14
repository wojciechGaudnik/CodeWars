package flatten_and_sort_an_array.kyu7;

import java.util.Arrays;

public class Kata {

	public static int[] flattenAndSort(int[][] array) {
		return Arrays.stream(array).flatMapToInt(Arrays::stream).sorted().toArray();
	}
}
   
