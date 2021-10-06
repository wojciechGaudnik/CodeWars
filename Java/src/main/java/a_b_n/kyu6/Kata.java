package a_b_n.kyu6;

import java.math.BigInteger;
import java.util.ArrayList;
import java.util.List;

class Kata {
	public static void main(String[] args) {
		System.out.println(pascal(9));
		System.out.println(Long.MAX_VALUE);
		System.out.println("6642296615638987380");
	}

	public static String formula(int m) {
		if (m == 0) {
			return "1";
		}
		var answer = new StringBuilder();
		var minus = m < 0;
		var f = Math.abs(m);
		var s = 0;
		var pascal = pascal(f + 1L);
		for (var one : pascal) {
			answer.append(one).append("a^").append(f--).append("b^").append(s++).append("+");
		}
		var pre = answer.toString()
				.replaceAll("^1", "")
				.replaceAll("[ab]\\^0", "")
				.replaceAll("\\^1(?=[\\+ab])", "")
				.replaceAll("\\+1a", "+a")
				.replaceAll("\\+1b", "+b")
				.replaceAll("\\+$", "");
		if (minus) {
			return "1/(" + pre + ")";
		}
		return pre;
	}

	public static List<BigInteger> pascal(long n) {
		var answer = new ArrayList<BigInteger>();
		for (long line = n; line <= n; line++) {
			BigInteger C = BigInteger.ONE;
			for (int i = 1; i <= line; i++) {
				answer.add(C);
				C = C.multiply(BigInteger.valueOf(line - i)).divide(BigInteger.valueOf(i));
			}
		}
		return answer;
	}
}
