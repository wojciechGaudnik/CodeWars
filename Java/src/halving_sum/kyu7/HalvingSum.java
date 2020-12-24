package halving_sum.kyu7;

public class HalvingSum {



	int halvingSum(int n) {
		var answer = 0;
		while (n >= 1) {
			answer += n;
			n /= 2;
		}
		return answer;
	}
}
