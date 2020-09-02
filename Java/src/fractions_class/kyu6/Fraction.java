package fractions_class.kyu6;

import java.math.BigInteger;

public class Fraction implements Comparable<Fraction> {
	private final long top;
	private final long bottom;

	public static void main(String[] args) {
		System.out.println(5 * 8);
		System.out.println(4 * 8);
		var fract1 = new Fraction(2, 5);
		var fract2 = fract1.add(new Fraction(2, 5));
		System.out.println(20 % 5);
		System.out.println(20 % 4);
		System.out.println(20 % 3);

	}

	public Fraction(long numerator, long denominator) {
		top = numerator;
		bottom = denominator;
	}

	@Override
	public int hashCode() {
		return 17 * Long.hashCode(top) + Long.hashCode(bottom);
	}

	@Override
	public boolean equals(Object o) {
		return compareTo((Fraction) o) == 0;
	}

	@Override
	public int compareTo(Fraction f2) {
		return Long.compare(top * f2.bottom, f2.top * bottom);
	}

	public Fraction add(Fraction f2) {
		var answerBottom = new BigInteger(String.valueOf(bottom * f2.bottom));
		var answerTop = new BigInteger(String.valueOf(top * f2.bottom + f2.top * bottom));
		var gcd = answerTop.gcd(answerBottom);
		return new Fraction(Long.parseLong(String.valueOf(answerTop.divide(gcd))), Long.parseLong(String.valueOf(answerBottom.divide(gcd))));
	}

	@Override
	public String toString() {
		return top + "/" + bottom;
	}
}
   
