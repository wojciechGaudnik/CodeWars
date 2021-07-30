package map_over_a_list_of_lists;

import java.util.function.Function;

public class Solution {

	public static <T, R> R[][] gridMap(Function<T, R> fn, T[][] list) {
		var outer = new Object[list.length][];
		for(var i = 0; i < list.length; i++) {
			var inner = new Object[list[i].length];
			for (var j = 0; j < list[i].length; j++) {
				inner[j] = fn.apply(list[i][j]);
			}
			outer[i] = inner;
		}
		return (R[][]) outer;
	}

}
