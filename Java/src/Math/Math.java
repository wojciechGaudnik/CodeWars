package Math;


import java.util.Arrays;
import java.util.stream.Stream;

public class Math {

	public static void main(String[] args) {
		System.out.println(Arrays.toString(Math.Interval(new int[] {-4154, -1960, -1501, - 4121}, "[-1993,-1571]")));

	}


	public static int[] Interval(int[] arr, String str) {
//		System.out.println(str + " " + arr[0] + " " + arr[1] + " " + arr[arr.length - 2] + " " + arr[arr.length - 1]);
		if (arr.length == 0 || str.length() == 0) {
			return new int[]{};
		}
		int [] numbers = Arrays.stream(str.substring(1, str.length() - 1).split(",\\s*")).mapToInt(Integer::parseInt).toArray();
		int leftInt = (str.charAt(0) == '(') ? numbers[0]: numbers[0] - 1;
		int rightInt = (str.charAt(str.length() - 1) == ')') ? numbers[1] : numbers[1] + 1;
		return Arrays.stream(arr).sorted().filter(e -> e > leftInt && e < rightInt).toArray();
	}
}
