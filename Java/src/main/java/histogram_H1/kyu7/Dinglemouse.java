package histogram_H1.kyu7;

public class Dinglemouse {
	public static String histogram(final int results[]) {
		var answer = new StringBuilder();
		for (int l = results.length, i = 0; l > 0; l--, i++) {
			answer.append(l + "|" + "#".repeat(results[l - 1]) + ((results[l - 1] == 0) ? "" : " " + results[l - 1]) + "\n");
		}
		return answer.toString();
	}
}
