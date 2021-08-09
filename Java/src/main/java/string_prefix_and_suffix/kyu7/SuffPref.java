package string_prefix_and_suffix.kyu7;

public class SuffPref {
	public static int solve(String s) {
		if (s.length() % 2 != 0) {
			s = s.substring(0, s.length() / 2) + s.substring(s.length() / 2 + 1);
		}
		while (s.length() > 0 && !isOk(s)) {
			s = s.substring(0, s.length() / 2 - 1) + s.substring(s.length() / 2 + 1);
		}
		return s.length() / 2;
	}

	private static boolean isOk(String s) {
		return s.substring(0, s.length() / 2).equals(s.substring(s.length() / 2));

	}
}
