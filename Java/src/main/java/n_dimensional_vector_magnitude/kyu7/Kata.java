package n_dimensional_vector_magnitude.kyu7;

import java.util.Arrays;

public class Kata {
	public static double magnitude(double[] vector) {
		return Math.sqrt(Arrays.stream(vector).map(v -> Math.pow(v, 2)).sum());
	}
}
