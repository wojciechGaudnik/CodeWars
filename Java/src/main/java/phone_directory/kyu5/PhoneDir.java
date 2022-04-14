package phone_directory.kyu5;

import java.util.HashMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class PhoneDir {


	public static String phone(String strng, String num) {
		var allNumbers = new HashMap<String, String>();
		String pattern = "\\d{1,2}-\\d{3}-\\d{3}-\\d{4}";
		Pattern numberPattern = Pattern.compile(pattern);

		for (var line : strng.split("\n")) {
			Matcher numberMatch = numberPattern.matcher(line);
			if (numberMatch.find()) {
				var number = numberMatch.group(0);
				if (allNumbers.containsKey(number) && number.equals(num)) return "Error => Too many people: " + num;
				else allNumbers.put(number, line);
			}
		}
		if (!allNumbers.containsKey(num)) return "Error => Not found: " + num;
		else return new JohnFriend(allNumbers.get(num)).toString();
	}
}

class JohnFriend {
	private String phone;
	private String name;
	private String address;

	public JohnFriend(String line) {
		String pattern = "\\d{1,2}-\\d{3}-\\d{3}-\\d{4}";
		Pattern numberPattern = Pattern.compile(pattern);
		Matcher numberMatch = numberPattern.matcher(line);
		if (numberMatch.find()) phone = numberMatch.group(0);
		line = line.replaceAll(pattern, "");

		pattern = "<.*>";
		Pattern namePattern = Pattern.compile(pattern);
		Matcher nameMatch = namePattern.matcher(line);
		if (nameMatch.find()) name = nameMatch.group(0).replaceAll("[<>]", "");
		line = line.replaceAll(pattern, "");

		line = line.trim().replaceAll("[\\+;:!/$,\\*\\?]", "").trim();
		address = line.trim().replaceAll("[\\s_]+", " ").trim();
	}

	@Override
	public String toString() {
		return "Phone => " + phone + ", " +
				"Name => " + name + ", " +
				"Address => " + address;
	}
}
   
