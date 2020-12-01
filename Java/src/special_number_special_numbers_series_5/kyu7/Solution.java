package special_number_special_numbers_series_5.kyu7;

public class Solution {

	public static String specialNumber(int number)	{
		for (var one : String.valueOf(number).toCharArray()) {
			if (Character.getNumericValue(one) > 5) {
				return "NOT!!";
			}
		}
		return "Special!!";
	}
}
