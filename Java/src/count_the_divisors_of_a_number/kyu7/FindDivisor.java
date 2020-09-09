package count_the_divisors_of_a_number.kyu7;

import java.util.stream.IntStream;

public class FindDivisor {
	public long numberOfDivisors(int n) {
		return IntStream.range(1, n + 1).filter(e -> n % e == 0).count();
	}
}
   
