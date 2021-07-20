package the_pony_express.kyu7;

public class Dinglemouse {

	public static int riders(final int[] stations) {
		var answer = 1;
		var part = 0;
		for (var one : stations) {
			if (part + one > 100) {
				part = one;
				answer++;
			} else {
				part += one;
			}
		}
		return answer;
	}
}
