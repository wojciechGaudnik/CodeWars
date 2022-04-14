package simple_remove_duplicates.kyu7;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.stream.Collectors;

public class Solution {

	public static int[] solve(int[] arr) {
		var list = new LinkedList<Integer>();
		var listBuff = Arrays.stream(arr).boxed().collect(Collectors.toList());
		while (!listBuff.isEmpty()) {
			var one = listBuff.get(0);
			if (listBuff.stream().filter(i -> i.equals(one)).count() > 1) {
				listBuff.remove(0);
				continue;
			}
			list.add(one);
			listBuff.remove(0);
		}

		var answer = new int[list.size()];
		for (var i = 0; i < list.size(); i++) {
			answer[i] = list.get(i);
		}
		return answer;
	}
}
