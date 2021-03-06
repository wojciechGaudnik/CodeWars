package string_array_duplicates.kyu6;

import java.util.Arrays;

public class Solution {
	public static void main(String[] args) {
		System.out.println(Arrays.toString(dup(new String[]{"ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo"})));
	}

	public static String[] dup(String[] arr) {
		var answer = new String[arr.length];
		for (var one : arr) {
			one = one.replaceAll("(.)\\1+", "$1");
			System.out.println(one);
		}

		var test = Arrays.stream(arr).map(s -> s.replaceAll("(.)\\1+", "$1")).toArray(String[]::new);
		return test;

	}
}
