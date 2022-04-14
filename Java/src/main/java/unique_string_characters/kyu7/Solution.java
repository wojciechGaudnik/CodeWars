package unique_string_characters.kyu7;

import java.util.stream.Collectors;

public class Solution {

	public static String solve(String a, String b) {
		var aPart = a.chars().mapToObj(c -> (char) c).filter(c -> b.indexOf(c) == -1).map(Object::toString).collect(Collectors.joining());
		var bPart = b.chars().mapToObj(c -> (char) c).filter(c -> a.indexOf(c) == -1).map(Object::toString).collect(Collectors.joining());
		return aPart + bPart;
	}
}
