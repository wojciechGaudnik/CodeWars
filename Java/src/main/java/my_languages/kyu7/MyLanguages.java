package my_languages.kyu7;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class MyLanguages {
	public static void main(String[] args) {
		final Map<String, Integer> map1 = new HashMap<>();
		map1.put("Java", 10);
		map1.put("Ruby", 80);
		map1.put("Python", 65);
		System.out.println(myLanguages(map1));
	}

	public static List<String> myLanguages(final Map<String, Integer> results) {
	 	return results.entrySet().stream()
	 			.filter(e -> e.getValue() >= 60)
	 			.sorted((e1, e2) -> e2.getValue().compareTo(e1.getValue()))
	 			.map(Map.Entry::getKey)
	 			.collect(Collectors.toList());
	}

}
