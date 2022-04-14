package array_element_parity.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Solution {

	public static void main(String[] args) {
		System.out.println(solve(new int[]{-110, 110, -38, -38, -62, 62, -38, -38, -38}));
	}

	public static int solve(int[] arr) {
		return Arrays.stream(arr).boxed()
				.collect(Collectors.toSet())
				.stream()
				.reduce(0, Integer::sum);
	}
}
