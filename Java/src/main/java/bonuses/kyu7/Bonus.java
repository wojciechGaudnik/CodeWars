package bonuses.kyu7;


import java.util.Arrays;

public class Bonus {
	public static void main(String[] args) {
		System.out.println(Arrays.toString(bonus(new int[]{23, 28, 29, 29, 15, 22, 29, 26, 20, 29, 19, 14, 17, 17, 25}, 90499821004L)));

	}


	public static long[] bonus(int[] arr, long s) {
		long[] answer = new long[arr.length];
		long i = 0;
		long add = 0;
		int max = Arrays.stream(arr).max().getAsInt();
		while (testCalc(arr, s, i, max) != 0) {
			while (testCalc(arr, s, i, max) < 0) {
				i += ++add;
			}
			add /= 2;
			while (testCalc(arr, s, i, max) > 0) {
				i -= ++add;
			}
			add /= 2;
		}
		calcNewArr(arr, answer, i, max, s);
		return answer;
	}

	private static int testCalc(int[] arr, long s, long x, int max) {
		long test = 0;
		long first = max * x;
		for (var j = 0; j < arr.length; j++) {
			test += first / arr[j];
		}
		return Long.compare(test, s);
	}

	private static void calcNewArr(int[] arr, long[] answer, long i, int max, long s) {
		long first;
		first = max * i;
		answer[0] = i;
		for (int j = 0; j < answer.length; j++) {
			answer[j] = first / arr[j];
		}
	}
















	public static long[] bonus2(int[] arr, long s) {

		long[] answer = new long[arr.length];
		long i = 0;
		long add = 0;
		int max = Arrays.stream(arr).max().getAsInt();
		while (Arrays.stream(answer).sum() != s) {
			while (Arrays.stream(answer).sum() < s) {
				i += ++add;
				calcNewArr(arr, answer, i, max, s);
			}
			add /= 2;
			while (Arrays.stream(answer).sum() > s) {
				i -= ++add;
				calcNewArr(arr, answer, i, max, s);
			}
			add /= 2;
		}
		return answer;
	}

	private static void calcNewArr2(int[] arr, long[] answer, long i, int max, long s) {
		long first;
		first = max * i;
		answer[0] = i;
		for (int j = 0; j < answer.length; j++) {
			answer[j] = first / arr[j];
		}
	}

	public static long[] bonus1(int[] arr, long s) {

		long[] answer = new long[arr.length];
		long i = 0;
		long add = 0;
		while (Arrays.stream(answer).sum() != s) {
			while (Arrays.stream(answer).sum() < s) {
				i += ++add;
				calcNewArr1(arr, answer, i);
			}
			add /= 2;
			while (Arrays.stream(answer).sum() > s) {
				i -= ++add;
				calcNewArr1(arr, answer, i);
			}
			add =0;
		}
		return answer;
	}

	private static void calcNewArr1(int[] arr, long[] answer, long i) {
		long first;
		first = arr[0] * i;
		answer[0] = i;
		for (int j = 1; j < answer.length; j++) {
			answer[j] = first / arr[j];
		}
	}
}
