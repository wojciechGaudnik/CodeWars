package string_task.kyu7;

public class StringTask {
	public static String perform(String word) {
		var vowels = "aoyeui";
		var answer = new StringBuilder();
		for (var one: word.toLowerCase().toCharArray()) {
			if (!vowels.contains(String.valueOf(one))) {
				answer.append(".").append(one);
			}
		}
		return answer.toString();
	}
}
