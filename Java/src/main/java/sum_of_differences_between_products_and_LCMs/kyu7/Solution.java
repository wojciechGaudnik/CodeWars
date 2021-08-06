//package sum_of_differences_between_products_and_LCMs.kyu7;
//
//import java.math.BigInteger;
//import java.util.Arrays;
//
//public class Solution {
//	public static int sumDifferencesBetweenProductsAndLCMs(final int[][] pairs) {
//		System.out.println(Arrays.deepToString(pairs));
//		System.out.println(lcm(15, 18));
//		System.out.println(lcm(4, 5));
//		System.out.println(lcm(12, 60));
//		return Math.toIntExact(Arrays.stream(pairs).mapToInt(p ->
//				BigInteger.valueOf(p[0]).multiply(BigInteger.valueOf(p[1])) - lcm(p[0], p[1])).sum());
//
//	}
//
//	public static int lcm(int number1, int number2) {
//		if (number1 == 0 || number2 == 0)
//			return 0;
//		else {
//			int gcd = gcd(number1, number2);
//			return Math.abs(number1 * number2) / gcd;
//		}
//	}
//
//	public static int gcd(int number1, int number2) {
//		if (number1 == 0 || number2 == 0) {
//			return number1 + number2;
//		} else {
//			int biggerValue = Math.max(number1, number2);
//			int smallerValue = Math.min(number1, number2);
//			return gcd(biggerValue % smallerValue, smallerValue);
//		}
//	}
//
////	public static int findGCF(int num1, int num2) {
////		if (num2 == 0) {
////			return num1;
////		} else {
////			return findGCF(num2, num1 % num2);
////		}
////	}
////
////	public static int findLCM(int num1, int num2) {
////		if (num1 == 0 || num2 == 0) {
////			return 0;
////		} else {
////			var gcd = gcd(num1, num2);
////			return Math.abs(num1 * num2) / gcd;
////		}
////	}
//}
