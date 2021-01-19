package indexed_capitalization.kyu7;

public class Solution {

	public static String capitalize(String s, int[] ind){
		var sArr = s.toCharArray();
		for (var one : ind) {
			if (one < sArr.length) {
				sArr[one] = Character.toUpperCase(sArr[one]);
			}
		}
		return new String(sArr);
	}
}
