package correct_the_time_string.kyu7;

public class Solution {
	public static String timeCorrect(String timestring) {
		if (timestring == null || timestring.isEmpty() || timestring.isBlank()) {
			return timestring;
		}
		if (timestring.matches("^\\d\\d:\\d\\d:\\d\\d$")) {
			var seconds = 0;
			var split = timestring.split(":");
			seconds += Integer.parseInt(split[0]) * 3600;
			seconds += Integer.parseInt(split[1]) * 60;
			seconds += Integer.parseInt(split[2]);
			seconds %= 86400;
			var answer = "";
			answer += String.format("%02d:", seconds / 3600);
			answer += String.format("%02d:", (seconds % 3600) / 60);
			answer += String.format("%02d", seconds % 60);
			return answer;
		}
		return null;
	}
}
