package not_prime_numbers.kyu7;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;

public class Solution {

	public static void main(String[] args) {
//		System.out.println(isPrime(2));
//		System.out.println(isPrime(3));
//		System.out.println(isPrime(5));
//		System.out.println(isPrime(7));
////		System.out.println(first(999));
////		System.out.println("2".compareTo("3"));
////
////		System.out.println("3".compareTo("2"));
////		System.out.println(first(123456789));
//
//
//		var test = new StringBuilder();
//		for (var i = 1; i < 10; i++) {
//			test.insert(0, i);
//		}
//		System.out.println(test);
		System.out.println(first(999));
		System.out.println(10 % 10);
		System.out.println(1 % 10);
		System.out.println(2 % 10);
		System.out.println(3 % 10);
	}

	private static Map<String, String> primes = new HashMap<>();

	static {
		primes.put("2", "3");
		primes.put("3", "5");
		primes.put("5", "7");
		primes.put("7", "2");
	}

	private static int first(int number) {
		var primes = "2357";
		var answer = new StringBuilder();
		for (var one : String.valueOf(number).toCharArray()) {
			if (!primes.contains(String.valueOf(one))) {
				for (var i = (int) one % 10; ; i++) {
					if (primes.contains(String.valueOf(i))) {
						answer.insert(0, i);
						break;
					}
				}
			} else {
				answer.insert(0, one);
			}
		}
		return Integer.parseInt(answer.toString());
	}

	public static List<Integer> notPrimes(int a, int b) {
		var answer = new ArrayList<Integer>();
		var answer2 = new LinkedList<Integer>();

//		for (var i = 1; ; i += 10) {
//
//		}
		return answer;
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
