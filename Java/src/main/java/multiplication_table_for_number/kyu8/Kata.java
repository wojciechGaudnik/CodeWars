package multiplication_table_for_number.kyu8;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Kata {
	public static String multiTable(int num) {
		return IntStream.range(1, 11).mapToObj(e -> e + " * " + num + " = " + e * num).collect(Collectors.joining("\n"));
	}
}
