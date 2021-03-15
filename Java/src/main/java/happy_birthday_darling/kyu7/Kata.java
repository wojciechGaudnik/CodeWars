package happy_birthday_darling.kyu7;

public class Kata {

	public static String womensAge(int n) {
		var radix = 2;
		while (true) {
			var number = toBaseN(n, radix++);
			if (number.equals("20") || number.equals("21")) {
				return n + "? That's just " + number + ", in base " + --radix + "!";
			}
		}
	}

	public static String toBaseN(int number, int baseN) {
		var answer = new StringBuilder();
		while (number > 0) {
			answer.append(number % baseN);
			number /= baseN;
		}
		return answer.reverse().toString();
	}
}
