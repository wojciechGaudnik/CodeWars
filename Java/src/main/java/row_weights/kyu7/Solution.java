package row_weights.kyu7;

import java.util.stream.IntStream;

public class Solution {

	public static int[] rowWeights (final int[] weights){
		var a = IntStream.range(0, weights.length).filter(i -> i % 2 == 0).map(i -> weights[i]).sum();
		var b = IntStream.range(0, weights.length).filter(i -> i % 2 == 1).map(i -> weights[i]).sum();
		return new int[]{a, b};
	}
}
   
