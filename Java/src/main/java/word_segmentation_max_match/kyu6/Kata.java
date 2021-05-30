package word_segmentation_max_match.kyu6;

import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Set;

public class Kata {


	public static List<String> maxMatch(String sentence) {
		var answer = new LinkedList<String>();
		for (var i = 0; i < sentence.length(); ) {
			for (var j = sentence.length(); j > i; j--) {
				var word = sentence.substring(i, j);
				if (Preloaded.VALID_WORDS.contains(word)) {
					answer.add(word);
					i += word.length();
					break;
				} else if (word.length() == 1) {
					answer.add(word);
					i += 1;
					break;
				}
			}
		}
		return answer;
	}
}

class Preloaded {

	public static Set<String> VALID_WORDS = new HashSet<>();

	static {
		VALID_WORDS.add("good");
		VALID_WORDS.add("luck");
		VALID_WORDS.add("e");
		VALID_WORDS.add("w");
		VALID_WORDS.add("in");
		VALID_WORDS.add("g");
		VALID_WORDS.add("s");
		VALID_WORDS.add("a");
	}
}
