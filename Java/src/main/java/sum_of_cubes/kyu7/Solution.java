package sum_of_cubes.kyu7;

import java.math.BigInteger;

public class Solution{
	public static int sumCubes1(int n){
		var n2 = BigInteger.valueOf(n).pow(2);
		var np1_2 = BigInteger.valueOf(n).add(BigInteger.ONE).pow(2);
		var answer= n2.multiply(np1_2).divide(BigInteger.valueOf(4));
		return answer.intValue();
	}
	public static int sumCubes(int n){
		System.out.println(n);
		var answer = 0;
		for (var i = 1; i <= n; i++) {
			answer += Math.pow(i, 3);
		}
		return answer;
	}
}