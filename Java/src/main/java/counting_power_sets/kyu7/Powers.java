package counting_power_sets.kyu7;

import java.math.BigInteger;

public class Powers {

	public static BigInteger powers(int[] list) {
		return BigInteger.TWO.pow(list.length);
	}
}
