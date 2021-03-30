package regexp_basics_is_it_a_hexadecimal_number.kyu7;

public class StringUtils {

	public static boolean isHexNumber(String s) {
		try {
			Long.parseLong(s
							.toUpperCase()
							.replaceAll("0X0X0", "")
							.replaceAll("^-", "z")
							.replaceAll("00X", "z")
							.replaceAll("0X", "")
					, 16);
		} catch (NumberFormatException e) {
			return false;
		}
		return true;
	}

}
