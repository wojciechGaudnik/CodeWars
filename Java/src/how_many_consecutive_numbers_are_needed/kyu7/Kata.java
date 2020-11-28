package how_many_consecutive_numbers_are_needed.kyu7;

import java.util.Arrays;

public class Kata {
	public static void main(String[] args) {
		System.out.println(consecutive(new int[]{529, -25, 137, 838, 505, -8, 723, 145, 333, 562, 569, 317, 139, 525, -17, 932, 120, 189, 685, 441, 421, 673, 47, -21, 444, 344, 403, 118, 907, 241, 286, 742, 972, 810, 737, 706, 746, 179, 487, 54, 75, 451, 437, 370, 598, 31, 251, 977, 822, 422, 754, 169, 568, 159, 248, 520, 45, 565, 225, 758, 528, 24, 637, 727, 892, 914, 514, 210, 865, 993, 816, 682, 460, 59, 429, 304, 961, 53, 913, -2, 40, 506, 211, 103, 924, 824, 676, 872, -31, 173, 35, 586, 156, 669, 51, 427, 967, 612, 804, 232}));
		System.out.println(consecutive(new int[]{4,8,6}));
	}
	public static int consecutive(final int[] arr) {
		Arrays.sort(arr);
		var answer = 0;
		for (var i = 0; i < arr.length - 1; i++) {
			if (arr[i] + 1 != arr[i + 1]) {
				answer += arr[i + 1] - arr[i] - 1;
			}
		}
		return answer;
	}
}
