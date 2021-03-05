package simple_string_reversal_II.kyu7;

public class Solution {
	public static String solve(String s, int a, int b){
		if (b >= s.length()) {
			b = s.length() - 1;
		}
		StringBuilder reversed = new StringBuilder();
		for (var i = a ; i <= b ; i++) {
			reversed.insert(0, s.charAt(i));
		}
		return s.substring(0, a) + reversed + s.substring(b + 1);
	}
}
