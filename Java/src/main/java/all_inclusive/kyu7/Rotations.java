package all_inclusive.kyu7;

import java.util.List;

public class Rotations {

	public static boolean containAllRots(String strng, List<String> arr) {
		var n = strng.length();
		while (n-- > 0) {
			if (!arr.contains(strng)) {
				return false;
			}
			strng = strng.substring(1) + strng.charAt(0);
		}
		return true;
	}
}
