package possibilities_array.kyu7;

import java.util.Objects;
import java.util.TreeSet;

public class Solution {

	public static boolean isAllPossibilities(int[] arg) {
		if (arg == null || arg.length == 0) {
			return false;
		}
		var set = new TreeSet<Integer>();
		for (var one : arg) {
			set.add(one);
		}
		return set.first() == 0 && Objects.equals(set.pollLast(), arg.length - 1);
	}

}