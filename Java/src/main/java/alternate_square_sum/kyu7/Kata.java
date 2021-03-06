package alternate_square_sum.kyu7;

public class Kata {
	public static int alternateSqSum(int[] arr) {
		var answer = 0;
		for (var i = 0; i < arr.length; i++) {
			if (i % 2 == 0) {
				answer += arr[i];
			} else {
				answer += Math.pow(arr[i], 2);
			}
		}
		return answer;
	}
}
