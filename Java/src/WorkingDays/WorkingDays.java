package WorkingDays;

import java.time.DayOfWeek;
import java.time.LocalDate;


public class WorkingDays {

	public static void main(String[] args) {
	}

	static long count(final LocalDate start, final LocalDate end) {
		LocalDate startChangeable = LocalDate.of(start.getYear(), start.getMonth(), 1);
		LocalDate endPlusMonth = LocalDate.of(end.getYear(), end.getMonth().getValue(), end.lengthOfMonth());
		while (startChangeable.getDayOfWeek() != DayOfWeek.MONDAY) {
			startChangeable = startChangeable.plusDays(1);
		}
		while (endPlusMonth.getDayOfWeek() != DayOfWeek.FRIDAY) {
			endPlusMonth = endPlusMonth.minusDays(1);
		}
		long workingDays = 1;
		while (!startChangeable.equals(endPlusMonth)) {
			if (startChangeable.getDayOfWeek() != DayOfWeek.SATURDAY && startChangeable.getDayOfWeek() != DayOfWeek.SUNDAY) {
				workingDays++;
			}
			startChangeable = startChangeable.plusDays(1);
		}
		return workingDays;
	}
}
