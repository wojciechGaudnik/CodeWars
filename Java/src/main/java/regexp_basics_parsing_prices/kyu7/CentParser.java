package regexp_basics_parsing_prices.kyu7;

import java.util.regex.Pattern;

class CentParser {

	public static Integer toCents(String price) {
		if (Pattern.compile("^\\$\\d*\\.\\d{1,2}$").asPredicate().test(price.replaceAll("\n", "*"))) {
			return Integer.valueOf(price.replaceAll("\\$", "").replaceAll("\\.", ""));
		}
		return null;
	}
}
