package nickname_generator.kyu7;

public class Generator {
	public static String nickname1(String name) {
		var vowels = "aeiou";
		if (name.length() < 4) {
			return "Error: Name too short";
		}
		if (vowels.contains(String.valueOf(name.charAt(2)))) {
			return name.substring(0, 4);
		}
		return name.substring(0, 3);
	}

	public static String nickname(String name) {
		return (name.length() < 4) ? "Error: Name too short" : ("aeiou".contains(String.valueOf(name.charAt(2)))) ? name.substring(0, 4) : name.substring(0, 3);
	}

}
