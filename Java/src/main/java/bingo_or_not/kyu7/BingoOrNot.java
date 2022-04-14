package bingo_or_not.kyu7;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.stream.Collectors;

public class BingoOrNot {

	public static String bingo(int[] numberArray) {
		return Arrays.stream(numberArray).boxed().collect(Collectors.toList()).containsAll(new LinkedList<>(Arrays.asList(2, 7, 9, 14, 15))) ? "WIN" : "LOSE";
	}

}
