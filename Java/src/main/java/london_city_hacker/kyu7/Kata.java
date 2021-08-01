package london_city_hacker.kyu7;

public class Kata {
	public static String londonCityHacker(Object[] journey) {
		var answer = 0.0;
		for (var i = 0; i < journey.length; i++) {
			if (journey[i] instanceof String) {
				answer += 2.4;
			} else if (journey[i] instanceof Integer && i + 1 < journey.length && journey[i + 1] instanceof Integer) {
				answer += 1.5;
				i++;
			} else {
				answer += 1.5;
			}
		}
		return String.format("£%.02f", answer);
	}

}

