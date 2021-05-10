package is_valid_identifier.kyu7;

public class IdentifierChecker {

	public static boolean isValid(String idn) {
		if (idn.length() == 0) {
			return false;
		}
		for (var one : idn.toCharArray()) {
			if (Character.isAlphabetic(one) || one == '_' || one == '$' || Character.isDigit(one)) {
				continue;
			}
			return false;
		}
		if (Character.isAlphabetic(idn.charAt(0)) || idn.charAt(0) == '_' || idn.charAt(0) == '$') {
			return true;
		}
		return false;
	}

}
