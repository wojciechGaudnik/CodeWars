package an_english_twist_on_a_japanese_classic.kyu7;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Shiritori {
	public static List<String> theGame(List<String> words) {
		var answer = new LinkedList<String>();
		if (words.isEmpty() || words.get(0).equals("")) {
			return new ArrayList<>();
		} else {
			answer.add(words.get(0));
		}
		for (var i = 0; i < words.size() - 1; i++) {
			if (words.get(i + 1).length() > 0 && words.get(i).charAt(words.get(i).length() - 1) == words.get(i + 1).charAt(0)) {
				answer.add(words.get(i + 1));
			} else {
				return answer;
			}
		}
		return answer;
	}
}
