package incrementer.kyu7;

import java.util.stream.IntStream;

public class Kata {

	public static int[] incrementer(int[] numbers) {
		return IntStream.range(1, numbers.length + 1).map(i -> (numbers[i - 1] + i) % 10).toArray();
	}

}