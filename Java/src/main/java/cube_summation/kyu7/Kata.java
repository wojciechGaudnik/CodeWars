package cube_summation.kyu7;

import java.util.stream.IntStream;

public class Kata {

	public static long cubeSum(int n, int m){
		var min = Math.min(n, m);
		var max = Math.max(n, m);
		return IntStream.range(min + 1, max + 1).mapToLong(e -> (long) Math.pow(e, 3)).sum();
	}

}