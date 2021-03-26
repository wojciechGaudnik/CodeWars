package easy_line.kyu7;

import java.math.BigInteger;

public class Easyline {
	public static void main(String[] args) {
		System.out.println(easyLine(4));
	}
	public static BigInteger easyLine(int n) {
		var answer = BigInteger.ONE;
		while (n-- > 0) {
			answer = answer.multiply(BigInteger.TWO).subtract(BigInteger.ONE);
		}
		return answer;
	}
}
