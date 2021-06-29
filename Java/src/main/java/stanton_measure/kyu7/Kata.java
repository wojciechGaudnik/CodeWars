package stanton_measure.kyu7;

import java.util.Arrays;

public class Kata {

	public static int stantonMeasure(int[] arr) {
		return (int) Arrays.stream(arr).filter(e -> e == Arrays.stream(arr).filter(c -> c == 1).count()).count();
	}
}
