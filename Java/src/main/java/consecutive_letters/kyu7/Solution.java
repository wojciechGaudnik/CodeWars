package consecutive_letters.kyu7;

import java.util.stream.Collectors;

public class Solution {

	public static boolean solve(String s){
		var sorted = s.chars().sorted().boxed().collect(Collectors.toList());
		return (sorted.get(0) + sorted.size() == sorted.get(sorted.size() - 1) + 1);
	}
}
