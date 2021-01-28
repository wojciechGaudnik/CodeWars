package credit_card_issuer_checking.kyu7;

public class Kata {

	public static String getIssuer(String cardNumber) {
		switch (cardNumber.charAt(0)) {
			case '3':
				if ((cardNumber.charAt(1) == '4' || cardNumber.charAt(1) == '7') && cardNumber.length() == 15) {
					return "AMEX";
				}
				break;
			case '4':
				if (cardNumber.length() == 13 || cardNumber.length() == 16) {
					return "VISA";
				}
				break;
			case '5':
				if (Integer.parseInt(cardNumber.substring(0, 2)) <= 55 && cardNumber.length() == 16) {
					return "Mastercard";
				}
				break;
			case '6':
				if (cardNumber.substring(1, 4).equals("011") && cardNumber.length() == 16) {
					return "Discover";
				}
				break;
		}
		return "Unknown";
	}
}
