package determine_the_date_by_the_day_number.kyu6;

import java.time.Instant;
import java.time.LocalDate;
import java.time.ZoneId;
import java.time.format.DateTimeFormatter;

public class Kata {
	public static String getDay(int day, boolean isLeap) {
		var epoch = (isLeap) ? 2L * 365 * 24 * 60 * 60 * 1000: 0;
		var instant= Instant.ofEpochMilli(epoch + day * 24L * 60 * 60 * 1000);
		var localDate = LocalDate.ofInstant(instant, ZoneId.systemDefault()).minusDays(1);
		var dateFormatter = DateTimeFormatter.ofPattern("MMMM, d");
		return dateFormatter.format(localDate);
	}
}
