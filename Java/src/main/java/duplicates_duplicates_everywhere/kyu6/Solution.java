package duplicates_duplicates_everywhere.kyu6;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

class Solution {
	public static Map<Integer, List<String>> removeDuplicateIds(Map<Integer, List<String>> obj) {
		var answer = new HashMap<Integer, List<String>>();
		var sortedKeys = new ArrayList<>(obj.keySet());
		Collections.sort(sortedKeys);
		for (var i = 0; i < sortedKeys.size(); i++) {
			var firstValues = obj.get(sortedKeys.get(i));
			for (var j = i + 1; j < sortedKeys.size(); j++) {
				firstValues = removeDuplicates(firstValues, obj.get(sortedKeys.get(j)));
			}
			answer.put(sortedKeys.get(i), removeDuplicatesInOne(firstValues));
		}
		return answer;
	}

	private static List<String> removeDuplicatesInOne(List<String> firstValues) {
		var answer = new ArrayList<String>();
		for (var oneFirst : firstValues) {
			if (!answer.contains(oneFirst)) {
				answer.add(oneFirst);
			}
		}
		return answer;
	}

	private static List<String> removeDuplicates(List<String> first, List<String> second) {
		var answer = new ArrayList<String>();
		for (var oneFirst : first) {
			if (!second.contains(oneFirst)) {
				answer.add(oneFirst);
			}
		}
		return answer;
	}
}
