package the_office_III_broken_photocopier.kyu7;

public class Kata {

	public static String broken(final String x) {
		var answer = new StringBuilder();
		for (var one : x.toCharArray()) {
			if (one == '0') {
				answer.append('1');
			} else {
				answer.append('0');
			}
		}
		return answer.toString();
	}
}
