package repeatIt.kyu8;

public class RepeatIt {
	public static String repeatString(final Object toRepeat, final int n) {
		if (toRepeat instanceof String) {
			return ((String) toRepeat).repeat(n);
		}
		return "Not a string";
	}
}
