package All;

import java.util.Arrays;

public class Kata {

	public static boolean isLove(final int flower1, final int flower2) {
		return flower1 % 2 != flower2 % 2;
	}

	public static int[] squareOrSquareRoot(int[] array) {
		return Arrays.stream(array).boxed().map(n -> {
			if ((Math.sqrt(n) - Math.floor(Math.sqrt(n))) == 0) {
				System.out.println(n);
				return (int) Math.sqrt(n);
			} else {
				return (int) Math.pow(n, 2);
			}
		}).mapToInt(Integer::intValue).toArray();
	}

	public static void main(String[] args) {
		System.out.println("test");
	}
}
