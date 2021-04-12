package lario_and_muigi_pipe_problem.kyu8;

import java.util.stream.IntStream;

public class Kata {
	public static int[] pipeFix(int[] numbers) {
		return IntStream.range(numbers[0], numbers[numbers.length - 1] + 1).toArray();
	}
}
