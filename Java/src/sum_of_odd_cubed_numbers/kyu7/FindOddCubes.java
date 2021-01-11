package sum_of_odd_cubed_numbers.kyu7;

import java.util.Arrays;

public class FindOddCubes {

	public static int cubeOdd(int arr[]) {
		return Arrays.stream(arr).filter(e -> e % 2 == 1 || e % 2 == -1).map(e -> (int) Math.pow(e, 3)).sum();
	}
}
