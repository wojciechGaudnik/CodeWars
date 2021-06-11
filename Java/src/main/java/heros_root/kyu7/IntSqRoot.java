package heros_root.kyu7;

public class IntSqRoot {

	public static long IntRac(long n, long guess)  {
		var answer = 0;
		while (true) {
			answer++;
			var temp = Math.floorDiv((guess + Math.floorDiv(n, guess)), 2);
			if (Math.abs(guess - temp) < 1) {
				return answer;
			}
			guess = temp;
		}
	}

}
