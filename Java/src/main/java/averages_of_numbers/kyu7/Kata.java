package averages_of_numbers.kyu7;

public class Kata {

	public static void main(String[] args) {

	}

	public static double[] averages(int[] numbers) {
		if (numbers == null || numbers.length <= 1) {
			return new double[0];
		}
		var answer = new double[numbers.length - 1];
		for (var i = 0; i < numbers.length - 1; i++) {
			answer[i] = (numbers[i] + numbers[i + 1]) / 2.0;
		}
		return answer;
	}
}
   
