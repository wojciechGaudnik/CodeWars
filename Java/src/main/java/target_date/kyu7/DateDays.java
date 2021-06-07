package target_date.kyu7;

import java.time.LocalDate;

public class DateDays {

	public static String dateNbDays(double a0, double a, double p) {
		var startDate = LocalDate.of(2016, 1, 1);
		double pDay;
		while (a0 < a) {
			pDay = a0 * (p / 36000);
			startDate = startDate.plusDays(1);
			a0 += pDay;
		}
		return startDate.toString();
	}
}
