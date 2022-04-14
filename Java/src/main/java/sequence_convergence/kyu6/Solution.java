package sequence_convergence.kyu6;

public class Solution {
	public static void main(String[] args) {
		System.out.println(convergence(3));
//		System.out.println(String.valueOf(123).chars().filter);
	}

	public static int convergence(int n) {
		var answer = -0;
		var first = 1;
		var second = n;
		while (first != second) {
			while (first < second) {
				first = next(first);
			}
			while (first > second) {
				second = next(second);
				answer++;
			}
		}
		return answer;
	}

	private static int next(int number) {
		if (number < 10) {
			return number * 2;
		} else {
			return number + String.valueOf(number).chars().map(e -> e - 48).filter(e -> e != 0).reduce(1, (a, b) -> a * b);
		}
	}
}
