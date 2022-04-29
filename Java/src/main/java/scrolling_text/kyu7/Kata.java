package scrolling_text.kyu7;

public class Kata {

	public static String[] scrollingText(String text) {
		var answer = new String[text.length()];
		text = text.toUpperCase();
		for (var i = 0; i < text.length(); i++) {
			var word = text.substring(i) + text.substring(0, i);
			answer[i] = word;
		}
		return answer;
	}

}