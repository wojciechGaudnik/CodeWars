package thb.kyu7;

public class THB {
	public static String testing(String initial) {
		if (initial == null) {
			return "";
		}
		return initial.replaceAll("(?i)[^tbh]", "");
	}

}
