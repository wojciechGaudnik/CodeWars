package simple_fun_2_circle_of_numbers.kyu7;

public class CircleOfNumbers {
	public static int circleOfNumbers(int n, int firstNumbers) {
		var half = n / 2;
		while (half-- != 0) {
			firstNumbers++;
			if (firstNumbers == n) {
				firstNumbers = 0;
			}
		}
		return firstNumbers;
	}
}
