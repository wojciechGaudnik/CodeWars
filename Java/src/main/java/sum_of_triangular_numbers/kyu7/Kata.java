package sum_of_triangular_numbers.kyu7;

import java.util.stream.IntStream;

public class Kata {

	public static int sumTriangularNumbers(int n){
		if (n < 0) return 0;
		var answer = 0;
		var t = 0;
		for (var x = 1; x <= n; x++) {
			t = IntStream.range(0, x + 1).sum();
			answer += t;
		}
		return answer;
	}
}
   
