package FindSubstring;


import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.Arrays;

public class FindSubstring {

	public static void main(String[] args) {
		System.out.println(FindSubstring.longestSubstring("<jQ/+Y=}5=/V>(RhXbgb7>i^>V)SZaP8?X/h/*<OV^Vd)dS6R0OS0 Q{YW6R/U/f", "4bYZSNVWWR8Xk^bc&5YSc }j){lh%3 dN<iQ 8l d g802>fOlaagbM(6`6128/g??3i&=Z*7*1"));

	}


	static int longestSubstring(String a, String b){
//		System.out.println(a + "\n <---> \n" + b);
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
