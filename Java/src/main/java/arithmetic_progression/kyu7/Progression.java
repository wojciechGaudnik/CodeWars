package arithmetic_progression.kyu7;

public class Progression {
	public static String arithmeticSequenceElements(int first, int step, long total) {
		StringBuilder answer = new StringBuilder();
		for (int i = first, j = 0; j < total; i += step, j++) {
			answer.append(i).append(", ");
		}
		return answer.substring(0, answer.length() - 2);
	}
}
