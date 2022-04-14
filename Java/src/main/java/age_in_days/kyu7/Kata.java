package age_in_days.kyu7;

import java.time.LocalDate;

class Kata {

	public static String ageInDays(int year, int month, int day) {
		var start = LocalDate.now();
		var end = LocalDate.of(year, month, day);
		var days = start.minusDays(end.toEpochDay()).toEpochDay();
		return "You are " + days + " days old";
	}
}
