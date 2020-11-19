package disarium_number_special_numbers_series3.kyu7;

import java.util.stream.IntStream;

public class Solution {

	public static String disariumNumber(int number)	{
		var numberString = String.valueOf(number);
		return (IntStream.range(1, numberString.length() + 1).map(i -> (int)Math.pow(numberString.charAt(i -1) - 48, i)).sum() == number) ? "Disarium !!" : "Not !!";
	}
}
