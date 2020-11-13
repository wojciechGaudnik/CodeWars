package FindSubstring;


import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.Arrays;

public class FindSubstring {

	static int longestSubstring(String a, String b){
		char[] aChars = a.toCharArray();
		char[] bChars = b.toCharArray();
		List<Character> both = new ArrayList<>();
		for (char charA : aChars) {
			for (char charB : bChars) {
				if (charA == charB) {
					both.add(charA);
				}
			}
		}
		if (both.size() == 0) {
			return a.length() + b.length();
		}
		Set<Character> uniqueSet = new HashSet<>(both);
		both = new ArrayList<>(uniqueSet);
		String regex = both.toString().replaceAll("(?<=.)\\[(?=.)", "\\\\[");

		regex = regex.replaceAll("(?<=.)\\](?=.)", "\\\\]");
		regex = regex.replaceAll("(?<=.)&(?=.)", "\\\\&");
		regex = regex.replaceAll("(?<=.)\\((?=.)", "\\\\(");
		regex = regex.replaceAll("(?<=.)\\)(?=.)", "\\\\)");
		regex = regex.replaceAll("(?<=.)\\*(?=.)", "\\\\*");
		regex = regex.replaceAll("(?<=.)/(?=.)", "\\\\/");
		regex = regex.replaceAll("(?<=.)=(?=.)", "\\\\=");
		regex = regex.replaceAll("(?<=.)\\?(?=.)", "\\\\?");
		regex = regex.replaceAll("(?<=.)`(?=.)", "\\\\`");
		regex = regex.replaceAll("(?<=.)\\{(?=.)", "\\\\{");
		regex = regex.replaceAll("(?<=.)}(?=.)", "\\\\}");
		regex = regex.replaceAll("(?<=.)\\.(?=.)", "\\\\.");
		regex = regex.replaceAll("(?<=.)\\+(?=.)", "\\\\+");
		regex = regex.replaceAll(" (?!,)", "");
		if (regex.equals("[]")) {
			regex = "[ \\\\]";
		}
		String ab = a + b;
		String ba = b + a;
		if (regex.length() == 0 || ab.split(regex).length == 0 || ba.split(regex).length == 0) {
			return 0;
		}
		int maxAB = Arrays.stream(ab.split(regex)).mapToInt(String::length).max().getAsInt();
		int maxBA = Arrays.stream(ba.split(regex)).mapToInt(String::length).max().getAsInt();
		return Math.max(maxAB, maxBA);
	}
}
