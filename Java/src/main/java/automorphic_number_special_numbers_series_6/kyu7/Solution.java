package automorphic_number_special_numbers_series_6.kyu7;

public class Solution {

	public static String autoMorphic(int number) {
		return String.valueOf(Math.pow(number, 2))
				.replace(".0", "")
				.endsWith(String.valueOf(number)) ? "Automorphic" : "Not!!";
	}
}
   
