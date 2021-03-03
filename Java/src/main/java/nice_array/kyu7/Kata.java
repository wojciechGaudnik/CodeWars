package nice_array.kyu7;

import java.util.Arrays;
import java.util.Map;
import java.util.Objects;
import java.util.stream.Collectors;

public class Kata {

	public static boolean isNice(Integer[] arr) {
		Objects.requireNonNull(arr);
		if (arr.length <= 1) {
			return false;
		}
		Arrays.sort(arr);
		var list = Arrays.stream(arr).collect(Collectors.toList());
		var map = list.stream().distinct().collect(Collectors.toMap(i -> i, i -> false));
		for (var i = 0; i < list.size() - 1; i++) {
			if (list.get(i) + 1 == list.get(i + 1)) {
				map.put(list.get(i), true);
				map.put(list.get(i + 1), true);
			}
		}
		return map.entrySet().stream().filter(Map.Entry::getValue).count() == map.size();
	}
}
