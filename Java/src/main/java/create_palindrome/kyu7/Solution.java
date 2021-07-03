package create_palindrome.kyu7;

public class Solution {

	public static boolean solve(String st) {
		for (int i = 0, j = st.length() - 1; i < j; i++, j--) {
			if (st.charAt(i) == st.charAt(j)) {
				continue;
			}
			if (Math.abs(st.charAt(i) - st.charAt(j)) == 2) {
				continue;
			}
			return false;
		}
		return true;
	}

}
