package spacify.kyu7;

import java.util.stream.Collectors;

public class Spacify {
	public static String spacify(String str) {
		return str.chars().mapToObj(c -> (char) c + " ").collect(Collectors.joining("")).trim();
	}
}
