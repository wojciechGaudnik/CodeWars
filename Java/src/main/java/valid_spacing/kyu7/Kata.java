package valid_spacing.kyu7;

public class Kata {

	public static boolean validSpacing(String s) {
		return s.length() == s.trim().length() && !s.contains("  ");
	}

}