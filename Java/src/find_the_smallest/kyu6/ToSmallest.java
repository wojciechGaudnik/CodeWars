package find_the_smallest.kyu6;


public class ToSmallest {

	public static long[] smallest(long n) {
		var answer = new long[]{n, 0, 0};
		var number = new StringBuilder(String.valueOf(n));
		var numberBuff = new StringBuilder(number);
		for (var i = 0; i < number.length(); i++) {
			var charToMove = number.charAt(i);
			numberBuff.deleteCharAt(i);
			for (var j = 0; j <= numberBuff.length(); j++) {
				numberBuff.insert(j, charToMove);
				if (Long.parseLong(numberBuff.toString()) == answer[0] && answer[1] > i) {
					answer = new long[]{Long.parseLong(numberBuff.toString()), i, j};
				}
				if (Long.parseLong(numberBuff.toString()) < answer[0]) {
						answer = new long[]{Long.parseLong(numberBuff.toString()), i, j};
					}
				numberBuff.deleteCharAt(j);
			}
			numberBuff.insert(i, charToMove);
		}
		return answer;
	}
}
