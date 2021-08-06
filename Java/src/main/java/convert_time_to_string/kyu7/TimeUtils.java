package convert_time_to_string.kyu7;

import java.time.Duration;

public class TimeUtils {

	public static String convertTime(int timeDiff) {
		var duration = Duration.ofSeconds(timeDiff);
		var days = duration.toDays();
		duration = duration.minusDays(days);
		var hours = duration.toHours();
		duration = duration.minusHours(hours);
		var minutes = duration.toMinutes();
		duration = duration.minusMinutes(minutes);
		var seconds = duration.toSeconds();
		return days + " " + hours + " " + minutes + " " + seconds;
	}
}
