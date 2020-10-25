package form_the_minimum.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Minimum {

	public static void main(String[] args) {
		System.out.println(minValue(new int[]{6, 7, 8, 7, 6, 6}));
	}

	public static int minValue(int[] values) {
		return Integer.parseInt(Arrays.stream(values)
				.sorted()
				.distinct()
				.mapToObj(Integer::toString)
				.collect(Collectors.joining("")));
		}
}

   
