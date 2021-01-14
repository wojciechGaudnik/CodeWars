package a_rule_of_divisibility_by_7.kyu7;

public class DivSeven {

	public static long[] seven(long m) {
		var steps = 0;
		while (m > 99) {
			var firstPart = m / 10;
			var secondPart = m % 10;
			m = firstPart - 2 * secondPart;
			steps++;
		}
		return new long[]{m, steps};
	}
}
   
