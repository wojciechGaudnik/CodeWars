package binary_scORe.kyu7;

import java.math.BigInteger;

public class BinaryScore {

	public static BigInteger score(BigInteger n) {
		return (n.equals(BigInteger.ZERO)) ? BigInteger.ZERO : new BigInteger("1".repeat(n.toString(2).length()), 2);
	}

}
