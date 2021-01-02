package collatz_conjecture_length.kyu7;

public class Collatz {

	public static void main(String[] args) {
		System.out.println(conjecture(20));
	}

	public static long conjecture(long x) {
		var answer = 1;
		while (x != 1) {
			answer++;
			if (x % 2 == 0) x /= 2;
			else x = (x * 3) + 1;
		}
		return answer;
	}

}
