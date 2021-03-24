package batman_quotes.kyu7;

public class BatmanQuotes {
	public static String getQuote(String[] quotes, String hero) {
		var index = -1;
		for (var one : hero.toCharArray()) {
			if (Character.isDigit(one)) {
				index = Integer.parseInt(String.valueOf(one));
				break;
			}
		}
		if (hero.charAt(0) == 'R') {
			return "Robin: " + quotes[index];
		} else if (hero.charAt(0) == 'B') {
			return "Batman: " + quotes[index];
		}
		return "Joker: " + quotes[index];
	}
}
