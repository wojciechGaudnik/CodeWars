package ean_validation.kyu7;

public class EANValidator {
	public static boolean validate(final String eanCode) {
		var answer = 0;
		for (var i = 0; i < eanCode.length() - 1; i++) {
			if (i % 2 == 0) {
				answer += Integer.parseInt(String.valueOf(eanCode.charAt(i)));
			} else {
				answer += Integer.parseInt(String.valueOf(eanCode.charAt(i))) * 3;
			}
		}
		answer = (10 - (answer % 10)) % 10;
		return answer == Integer.parseInt(String.valueOf(eanCode.charAt(12)));
	}
}
