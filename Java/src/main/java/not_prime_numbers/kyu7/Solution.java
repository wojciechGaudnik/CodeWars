package not_prime_numbers.kyu7;

import java.util.HashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class Solution {

	private static Map<Character, Character> primes = new HashMap<>();

	static {
		primes.put('2', '3');
		primes.put('3', '5');
		primes.put('5', '7');
		primes.put('7', '2');
	}

	public static List<Integer> notPrimes(int a, int b) {
		var answer = new LinkedList<Integer>();
		a = first(a);
		while (a < b) {
			if (!isPrime(a)) {
				answer.add(a);
			}
			a = next(a);
		}
		return answer.stream().sorted().collect(Collectors.toList());
	}

	private static int first(int num) {
		while (true) {
			if (String.valueOf(num).replaceAll("2|3|5|7", "").equals("")) {
				return num;
			}
			num++;
		}
	}

	private static int first1(int num) {
		var number = String.valueOf(num);
		var answer = new StringBuilder();
		var prime = "2357";
		for (var one : number.toCharArray()) {
			var oneInt = Integer.parseInt(String.valueOf(one));
			while (!prime.contains(String.valueOf(oneInt))) {
				oneInt++;
				if (oneInt >= 10) {
					oneInt = 1;
				}
			}
			answer.insert(0, oneInt);
		}
		if (number.charAt(0) == '8' || number.charAt(0) == '9') {
			answer.insert(0, 2);
		}
		return Integer.parseInt(answer.reverse().toString());
	}

	private static int next(int num) {
		var number = new StringBuilder(String.valueOf(num)).reverse().toString();
		var switchDigit = true;
		var answer = new StringBuilder();
		for (var one : number.toCharArray()) {
			if (switchDigit && one == '7') {
				answer.insert(0, primes.get(one));
			} else if (switchDigit) {
				answer.insert(0, primes.get(one));
				switchDigit = false;
			} else {
				answer.insert(0, one);
			}
		}
		if (switchDigit) {
			answer.insert(0, '2');
		}
		number = answer.toString();
		return Integer.parseInt(number);
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
