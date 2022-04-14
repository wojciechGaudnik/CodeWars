package simple_nearest_prime.kyu6;

public class Solution {

	public static long solve(long n) {
		if (isPrime(n)) return n;
		long down = n;
		long up = n;
		for (; ; down--, up++) {
			if (isPrime(down)) return down;
			if (isPrime(up)) return up;
		}
	}

	public static boolean isPrime(long number) {
		if (number == 2 || number == 3) return true;
		if (number % 2 == 0) return false;
		long sqrt = (long) Math.sqrt(number) + 1L;
		for (int i = 3; i < sqrt; i += 2) {
			if (number % i == 0) return false;
		}
		return true;
	}
}
