package most_digits.kyu7;

public class MostDigits {

	public static int findLongest(int[] numbers) {
		var answer = numbers[0];
		for (var one : numbers) {
			if (String.valueOf(Math.abs(one)).length() > String.valueOf(Math.abs(answer)).length()) {
				answer = one;
			}
		}
		return answer;
	}
}
   
