package jumping_number_special_numbers_series.kyu7;

public class Solution {

	public static String jumpingNumber(int number){
		if (number < 10) return "Jumping!!";
		var chars = String.valueOf(number).toCharArray();
		var last = Character.getNumericValue(chars[0]);
		for (var i = 1; i < chars.length; i++) {
			var actual = Character.getNumericValue(chars[i]);
			if (Math.abs(actual - last) > 1) {
				return "Not!!";
			}
			last = actual;
		}
		return "Jumping!!";
	}
}
