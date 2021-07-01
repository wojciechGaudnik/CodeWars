package ShiftLeft.kyu7;

public class Solution {
	public static int shiftLeft(String a, String b) {
		var aLength = a.length() - 1;
		var bLength = b.length() - 1;
		while (aLength >= 0 && bLength >= 0 && a.charAt(aLength) == b.charAt(bLength)) {
			aLength--;
			bLength--;
		}
		return (aLength + 1) + (bLength + 1);
	}
}
