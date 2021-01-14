package factorial_decomposition.kyu5;

import java.util.LinkedHashMap;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class FactDecomp {

	public static String decomp(int n) {
		var map = new LinkedHashMap<Integer, Integer>();
		var answer = new StringBuilder();
		var factorialList = IntStream.range(2, n + 1).boxed().collect(Collectors.toList());
		for (var i = 0; i < factorialList.size(); i++) {
			var number = factorialList.get(i);
			for (int j = 2; j <= number; j++) {
				while (number % j == 0) {
					if (map.containsKey(j)) map.replace(j, map.get(j) + 1);
					else map.put(j, 1);
					number /= j;
				}
			}
		}

		for (var one : map.entrySet()) {
			if (one.getValue() == 1) answer.append(one.getKey()).append(" * ");
			else answer.append(one.getKey()).append("^").append(one.getValue()).append(" * ");
		}
		return answer.delete(answer.length() - 3, answer.length()).toString();
	}

}

