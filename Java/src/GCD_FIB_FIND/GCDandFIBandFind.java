package GCD_FIB_FIND;

import java.math.BigInteger;

public class GCDandFIBandFind {
	public static BigInteger[] findInitialNumbers(long divisor, long iterations) {
//        System.out.println(divisor + " " + iterations);
		BigInteger temp = BigInteger.valueOf((0));
		BigInteger first = BigInteger.valueOf((divisor));
		BigInteger second = BigInteger.valueOf((divisor * 2));
		while (iterations-- > 0) {
			temp = first;
			first = second;
			second = second.add(temp) ;
		}
		return new BigInteger[] {first, temp};
	}




}
