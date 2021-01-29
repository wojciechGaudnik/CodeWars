package partial_word_searching.kyu7;

import java.util.Arrays;
import java.util.LinkedList;

public class WordSearch {
	public static void main(String[] args) {
		System.out.println(Arrays.toString(findWord("me", new String[]{"home", "milk", "Mercury", "fish"})));
	}

	static String[] findWord(String x, String[] y){
		var answer = new LinkedList<String>();
		for (var one : y) {
			if (one.matches("(?i).*" + x + ".*")) {
				answer.add(one);
			}
		}
		if (answer.size() == 0) {
			answer.add("Empty");
		}
		return answer.toArray(new String[answer.size()]);
	}
}
