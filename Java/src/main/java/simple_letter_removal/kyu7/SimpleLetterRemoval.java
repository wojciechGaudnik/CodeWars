package simple_letter_removal.kyu7;

import java.util.Arrays;

public class SimpleLetterRemoval {
	public static void main(String[] args) {
		System.out.println(solve("abracadabra", 1));
	}

	public static String solve(String s, int k) {
		var charArray = s.toCharArray();
		Arrays.sort(charArray);
		char[] toRemove = Arrays.copyOfRange(charArray, 0, k);
		for (var one : toRemove) {
			s = s.replaceFirst(String.valueOf(one), "*");
		}
		return s.replaceAll("\\*", "");
	}
}
