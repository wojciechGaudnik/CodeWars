package maximum_depth_of_nested_brackets.kyu6;

import java.util.LinkedList;
import java.util.List;

class CodeWars {
	public static List<String> stringsInMaxDepth(String s) {
		if (s.isEmpty() || s.chars().filter(c -> c == '(').count() == 0L) {
			return new LinkedList<>() {{addFirst(s);}};
		}
		var maxDepth = 0;
		var count = 0;
		for (var i = 0; i < s.length(); i++) {
			if (s.charAt(i) == '(') {
				count++;
			} else if (s.charAt(i) == ')') {
				count--;
			}
			if (count > maxDepth) {
				maxDepth = count;
			}
		}
		var answer = new LinkedList<String>();
		for (var i = 0; i < s.length(); i++) {
			if (s.charAt(i) == '(') {
				count++;
			} else if (s.charAt(i) == ')') {
				count--;
			}
			if (count == maxDepth) {
				var buff = new StringBuilder();
				var j = i;
				while (s.charAt(++j) != ')') {
					buff.append(s.charAt(j));
				}
				i = --j;
				answer.add(buff.toString());
			}
		}
		return answer;
	}
}
