package duplicates_duplicates_everywhere.kyu6;

import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

class Utils {
	public static Map<Integer, List<String>> createObject(Object[]... val) {
		var answer = new HashMap<Integer, List<String>>();
		for (var one : val) {
			var key = (Integer) one[0];
			var strVal = (String[]) one[1];
			var strValList = Arrays.stream(strVal).collect(Collectors.toList());
			answer.put(key, strValList);
		}
		return answer;
	}
}
