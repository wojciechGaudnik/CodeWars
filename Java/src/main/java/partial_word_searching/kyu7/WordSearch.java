package partial_word_searching.kyu7;

import java.util.LinkedList;

public class WordSearch {

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
