package message_validator.kyu6;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class Kata {
	public static void main(String[] args) {
		System.out.println(isAValidMessage("code4hello5"));
	}

	public static boolean isAValidMessage(String message) {
		if (message.equals("0") || message.equals("")) return true;
		if (!Character.isDigit(message.charAt(0))) return false;
		var words = Arrays.stream(message.split("\\d+")).filter(s -> s.length() != 0).collect(Collectors.toList());
		var matcher = Pattern.compile("\\d+").matcher(message);
		var numbers = new ArrayList<Integer>();
		for (var i = 0; matcher.find(); ) numbers.add(Integer.parseInt(matcher.group()));
		if (words.size() != numbers.size()) return false;
		for (var i = 0; i < words.size(); i++) {
			if (words.get(i).length() != numbers.get(i)) {
				return false;
			}
		}
		return true;
	}

}
