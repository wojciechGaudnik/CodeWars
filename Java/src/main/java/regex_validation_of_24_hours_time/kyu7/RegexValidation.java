package regex_validation_of_24_hours_time.kyu7;

import java.util.regex.Pattern;

public class RegexValidation {
	public static boolean validateTime(String time) {
		return Pattern.compile("^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$").asPredicate().test(time);
	}
}
