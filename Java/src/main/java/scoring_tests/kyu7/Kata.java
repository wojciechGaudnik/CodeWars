package scoring_tests.kyu7;

import java.util.Arrays;

public class Kata {
	public static int sol(int[] arr, int r, int o, int w){
		return (int)(
				Arrays.stream(arr).filter(e -> e == 0).count() * r +
						Arrays.stream(arr).filter(e -> e == 1).count() * o -
						Arrays.stream(arr).filter(e -> e == 2).count() * w);
	}
}