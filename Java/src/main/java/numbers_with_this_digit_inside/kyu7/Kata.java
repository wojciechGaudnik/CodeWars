package numbers_with_this_digit_inside.kyu7;

public class Kata {
	public static long[] NumbersWithDigitInside(long x, long d)  {
		var answer = new long[]{0,0,1};
		var dString = String.valueOf(d);
		for (var i = 1; i <= x; i++) {
			if (String.valueOf(i).contains(dString)) {
				answer[0] += 1;
				answer[1] += i;
				answer[2] *= i;
			}
		}
		if (answer[0] == 0) {
			answer[2] = 0;
		}
		return answer;
	}
}
