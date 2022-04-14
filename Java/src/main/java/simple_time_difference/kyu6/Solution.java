package simple_time_difference.kyu6;

import java.time.Duration;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.temporal.ChronoUnit;
import java.util.Arrays;
import java.util.stream.Collectors;

public class Solution {

	public static String solve(String[] arr) {
		if (arr.length == 1) {
			return "23:59";
		}
		var times = Arrays.stream(arr)
				.map(s -> LocalTime.of(Integer.parseInt(s.split(":")[0]), Integer.parseInt(s.split(":")[1])))
				.sorted()
				.collect(Collectors.toList());
		var maxDuration = Duration.of(1, ChronoUnit.MILLIS);
		for (var i = 0; i < times.size() - 1; i++) {
			if ((Duration.between(times.get(i), times.get(i + 1)).compareTo(maxDuration) > 0)) {
				maxDuration = Duration.between(times.get(i), times.get(i + 1));
			}
		}
		var today = LocalDateTime.of(LocalDate.now(), times.get(times.size() - 1));
		var tomorow = LocalDateTime.of(LocalDate.now().plusDays(1), times.get(0));
		if ((Duration.between(today, tomorow)).compareTo(maxDuration) > 0) {
			maxDuration = Duration.between(today, tomorow);
		}
		maxDuration = maxDuration.minusMinutes(1);
		return String.format("%02d:%02d", maxDuration.toHours(), maxDuration.toMinutes() % 60);
	}
}
