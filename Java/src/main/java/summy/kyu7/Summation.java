package summy.kyu7;

import java.util.Arrays;

public class Summation {
	static long summy(String stringOfInts) {
		return Arrays.stream(stringOfInts.split(" ")).mapToLong(Long::parseLong).sum();
	}
}
