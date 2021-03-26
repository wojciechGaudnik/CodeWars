package exclamation_marks_series_5_remove_all_exclamation_marks_from_the_end_of_words.kyu7;

public class R {

	public static String removeBang(String str) {
		var answer = new StringBuilder();
		for (var one : str.split(" ")) {
			answer.append(one.replaceAll("!*$", "")).append(" ");
		}
		return answer.toString().trim();
	}
}
