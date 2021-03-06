package count_the_characters.kyu7;

public class CC {

	public static int charCount(String str, char c) {
		return (int) str
				.toLowerCase().chars().filter(e -> (char) e == Character.toLowerCase(c)).count();
	}
}
