package buddy_pairs.kyu5;

class Bud {
	public static String buddy(long start, long limit) {
		for (var n = start; n < limit; n++) {
			var sum1 = sumDivisors(n) - 1;
			var sum2 = sumDivisors(sum1);
			if (sum2 - 1 == n && sum1 > n) {
				return String.format("(%d %d)", n, sum1);
			}
		}
		return "Nothing";
	}

	static long sumDivisors(long n) {
		var answer = 1;
		for (long i = 2; i <= Math.sqrt(n); i++) {
			if (n % i == 0) {
				if (n / i == i)
					answer += i;
				else
					answer += i + n / i;
			}
		}
		return answer;
	}

}
