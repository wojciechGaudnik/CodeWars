package matrix_addition_of_elements.kyu7;

import java.util.Arrays;

public class Sid {

	public static int sumOfElements(int matrix[][]) {
		return Arrays.stream(matrix).flatMapToInt(Arrays::stream).sum();
	}

}