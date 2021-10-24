package decimal_to_factorial_and_back.kyu5;

class Dec2Fact {
	private static String base = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	public static String dec2FactString(long nb) {
		var answer = new StringBuilder("0");
		for (var i = 2; nb > 0; nb /= i++) {
			answer.insert(0, base.charAt((int) (nb % i)));
		}
		return answer.toString();
	}

	public static long factString2Dec(String str) {
		long answer = 0;
		long multiplier = 1;
		for (int i = 0, j = str.length() - 1; j >= 0; i++, j--) {
			if (i > 1) {
				multiplier *= i;
			}
			answer += multiplier * base.indexOf(str.charAt(j));
		}
		return answer;
	}
}