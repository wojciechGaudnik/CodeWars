package Pandemia;

import java.util.regex.Pattern;

public class Pandemia {

	public static double infected(String input) {
		var total = input.chars().filter(c -> c != 'X').count();
		if (total == 0) {
			return 0;
		}
		var matcher = Pattern.compile("0*1+0*").matcher(input);
		var infected = 0;
		while (matcher.find()) {
			infected += matcher.group().length();
		}
		return 100 * ((double) infected / total);
	}

	public static void main(String[] args) {
		System.out.print(infected("01000000X000X011X0X"));
	}
}