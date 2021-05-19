package ordering_the_words.kyu7;

import java.util.Arrays;

public class Ordering {
	public String orderWord(String s){
		if (s == null || s.isEmpty()) {
			return "Invalid String!";
		}
		var arr = s.toCharArray();
		Arrays.sort(arr);
		return new String(arr);
	}
}
