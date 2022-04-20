package very_even_numbers.kyu7;


public class Kata {
	public static boolean isVeryEvenNumber(int number) {
		var numberStr = String.valueOf(number);
		while (numberStr.length() != 1) {
			var sum = numberStr.chars().mapToObj(Character::getNumericValue).mapToInt(Integer::intValue).sum();
			numberStr = String.valueOf(sum);
		}
		return Integer.parseInt(numberStr) % 2 == 0;
	}
}