package camel_case_to_underscore;

public class CamelCaseTranslator {
	public static String toUnderScore(String name) {
		var answer = new StringBuilder();
		answer.append(name.charAt(0));
		var firstDigit = true;
		for (var one : name.substring(1).toCharArray()) {
			if (!Character.isDigit(one)) {
				firstDigit = true;
			}
			if (Character.isDigit(one) && firstDigit) {
				answer.append("_").append(one);
				firstDigit = false;
				continue;
			}
			if (Character.isUpperCase(one)) {
				answer.append("_").append(one);
				continue;
			}
			answer.append(one);
		}
		return answer.toString().replace("__", "_");
	}
}
