package finding_remainder_without_using_operator.kyu7;

public class RemainderFinder {

	public static SimpleInteger remainder(SimpleInteger dividend, SimpleInteger divisor) {
		return dividend.subtract(dividend.divide(divisor).multiply(divisor));
	}

}
