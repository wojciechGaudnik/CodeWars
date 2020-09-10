package maximum_length_difference.kyu7;

import java.util.stream.Stream;

public class MaxDiffLength {

	public static int mxdiflg(String[] a1, String[] a2) {
		if (a1.length == 0 || a2.length == 0) {
			return -1;
		}
		var a1max = Stream.of(a1).mapToInt(String::length).max().getAsInt();
		var a1min = Stream.of(a1).mapToInt(String::length).min().getAsInt();
		var a2max = Stream.of(a2).mapToInt(String::length).max().getAsInt();
		var a2min = Stream.of(a2).mapToInt(String::length).min().getAsInt();
		return Math.max(Math.abs(a1max - a2min), Math.abs(a2max - a1min));
	}
}
   
