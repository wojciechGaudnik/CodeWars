package currying_functions_multiply_all_elements_in_an_array.kyu7;

import java.util.Arrays;
import java.util.function.Function;

public class Kata {

	public static Function<Integer, int[]> multiplyAll(int[] array) {
		return (a) -> Arrays.stream(array).map(e -> e * a).toArray();
	}
}
