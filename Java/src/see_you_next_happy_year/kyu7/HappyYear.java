package see_you_next_happy_year.kyu7;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class HappyYear {

//	public static void main(String[] args) {
//
//		var test = 123444567;
//		System.out.println(String.valueOf(test).toCharArray());
//		System.out.println();
//
//
////		System.out.println(String.valueOf(1234).toCharArray().collect(Collectors.toSet()).size());
//
//		System.out.println(nextHappyYear(2013));
//
//	}

	static public int nextHappyYear(int year) {
		return IntStream.range(year + 1, year * 2)
				.filter(y -> String.valueOf(y)
						.chars()
						.boxed()
						.collect(Collectors.toSet())
						.size() == String.valueOf(y).length())
				.findFirst()
				.getAsInt();
	}
}
