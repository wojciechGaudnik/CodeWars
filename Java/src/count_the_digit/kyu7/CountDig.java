package count_the_digit.kyu7;


import java.util.stream.IntStream;

public class CountDig {
	public static int nbDig(int n, int d) {
		return IntStream
				.range(0, n + 1)
				.mapToObj(i -> String.valueOf((int) Math.pow(i, 2)))
				.mapToInt(number -> (int) number.chars().filter(e -> e == d + 48).count())
				.sum();
	}
}
   
