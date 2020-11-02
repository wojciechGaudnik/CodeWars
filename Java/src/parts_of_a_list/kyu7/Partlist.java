package parts_of_a_list.kyu7;

import java.util.Arrays;

public class Partlist {

	public static String[][] partlist(String[] arr) {
		var answer = new String[arr.length - 1][];
		var last = arr.length;
		var index = 0;
		for (var i = 1; i < last; i++) {
			var left = String.join(" ", Arrays.copyOfRange(arr, 0, i)).trim();
			var right = String.join(" ", Arrays.copyOfRange(arr, i, last));
			var part = new String[]{left, right};
			answer[index++] = part;
		}
		return answer;
	}

}
   
