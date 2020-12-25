package arithmetic_sequence.kyu7;

public class Sequence {

	public static int nthterm(int first, int n, int c) {
		var m = 0;
		var answer = first;
		while (m != n) {
			answer += c;
			m++;
		}
		return answer;
	}
}
