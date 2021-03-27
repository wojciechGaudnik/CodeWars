package easy_line.kyu7;

import java.math.BigInteger;
import java.util.LinkedList;

public class Easyline {
	public static BigInteger easyLine(int n) {
		var firstLine = new LinkedList<BigInteger>();
		firstLine.add(BigInteger.ONE);
		var secondLine = new LinkedList<BigInteger>();
		secondLine.add(BigInteger.ONE);
		while (n-- > 0) {
			for (var i = 0; i + 1 < firstLine.size(); i++) {
				secondLine.add(firstLine.get(i).add(firstLine.get(i + 1)));
			}
			secondLine.add(BigInteger.ONE);
			firstLine.clear();
			firstLine.addAll(secondLine);
			secondLine.clear();
			secondLine.add(BigInteger.ONE);
		}
		return firstLine.stream().map(e -> e.pow(2)).reduce(BigInteger.ZERO, BigInteger::add);
	}
}
