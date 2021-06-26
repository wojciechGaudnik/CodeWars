package the_first_non_repeated_character_in_a_string.kyu7;

public class FirstNonRepeated {

	public static Character firstNonRepeated(String source) {
		for (var one : source.toCharArray()) {
			if (source.chars().filter(ch -> ch == one).count() == 1) {
				return one;
			}
		}
		return null;
	}

}
