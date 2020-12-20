package lunar_mathematics_addition.kyu7;

public class LunarCalculator {

	public static long add(long number1, long number2){
		var number1Str = new StringBuilder(String.format("%020d", number1)).reverse().toString().toCharArray();
		var number2Str = new StringBuilder(String.format("%020d", number2)).reverse().toString().toCharArray();
		var answer = new StringBuilder();

		for (var i = 0; i < 20; i++) {
			if (number1Str[i] > number2Str[i]) answer.insert(0, number1Str[i]);
			else answer.insert(0, number2Str[i]);
		}
		return Long.parseLong(answer.toString());
	}
}
