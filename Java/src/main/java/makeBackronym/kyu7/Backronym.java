package makeBackronym.kyu7;

import java.util.HashMap;
import java.util.Map;

public class Backronym {

	private static Map<String, String> dictionary = new HashMap<>() {{
		put("P", "perfect");
		put("M", "mustache");
	}};

	public static String makeBackronym(String acronym) {
		System.out.println(acronym);
		dictionary.put("", "");
		StringBuilder answer = new StringBuilder();
		for (var one : acronym.split("")) {
			answer.append(dictionary.get(one.toUpperCase())).append(" ");
		}
		return answer.toString().trim();
	}


}
