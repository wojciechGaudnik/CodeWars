package guess_the_sequence.kyu7;

import java.util.stream.IntStream;

class JomoPipi {
	static int[] sequence(int x) {
		return IntStream.range(1, x + 1)
				.mapToObj(String::valueOf)
				.sorted()
				.mapToInt(Integer::valueOf)
				.toArray();
	}

}
