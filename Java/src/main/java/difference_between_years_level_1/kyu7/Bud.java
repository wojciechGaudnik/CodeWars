package difference_between_years_level_1.kyu7;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Locale;

public class Bud {

	public static int howManyYears(String date1, String date2) {
		var formatter = DateTimeFormatter.ofPattern("yyyy/M/d", Locale.US);
		return Math.abs(LocalDate.parse(date1, formatter).getYear() - LocalDate.parse(date2, formatter).getYear());
	}

}