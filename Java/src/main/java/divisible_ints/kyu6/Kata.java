package divisible_ints.kyu6;


public class Kata {

	public static int getCount(int n) {
		var answer = 0;
		var number = String.valueOf(n);
		for (var i = 1; i < number.length(); i++) {
			for (var j = 0; j + i <= number.length(); j++) {
				var subNumber = Integer.parseInt(number.substring(j, j + i));
				if (subNumber == 0) continue;
				if (n % subNumber == 0) answer++;
			}
		}
		return answer;
	}
}
