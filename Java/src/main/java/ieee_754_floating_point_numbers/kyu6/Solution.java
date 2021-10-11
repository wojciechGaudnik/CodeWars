package ieee_754_floating_point_numbers.kyu6;

import java.util.HashMap;
import java.util.Map;

class Solution {

	public static void main(String[] args) {
		var test = 15.875f;
		var intBits = Float.floatToIntBits(test);
		var binary = Integer.toBinaryString(intBits);
		System.out.println(binary);
		System.out.println((test < 0) ? "1 " : "0 " + binary.substring(0, 8) + " " + binary.substring(9));
		var intBits2 = Double.doubleToLongBits(test);
		var binary2 = Long.toBinaryString(intBits2);
		System.out.println(binary2);
	}

	static Map<Double, String> doubleStringMap = new HashMap<>();
	static Map<Float, String> floatStringMap = new HashMap<>();

	static {
		doubleStringMap.put(Double.NaN, "0 11111111111 1110101110101001010101100101100110100010010100111101");
		doubleStringMap.put(-Double.NaN, "1 11111111111 1110101110101001010101100101100110100010010100111101");
		doubleStringMap.put(-1.0, "1 01111111111 0000000000000000000000000000000000000000000000000000");
		doubleStringMap.put(Double.NEGATIVE_INFINITY, "1 11111111111 0000000000000000000000000000000000000000000000000000");
		doubleStringMap.put(+0.0, "0 00000000000 0000000000000000000000000000000000000000000000000000");
		doubleStringMap.put(-0.0, "1 00000000000 0000000000000000000000000000000000000000000000000000");
		doubleStringMap.put(-Double.MAX_VALUE, "1 11111111110 1111111111111111111111111111111111111111111111111111");
		doubleStringMap.put(+Double.MIN_VALUE, "0 00000000000 0000000000000000000000000000000000000000000000000001");
		doubleStringMap.put(-Double.MIN_VALUE, "1 00000000000 0000000000000000000000000000000000000000000000000001");
	}

	static {
		floatStringMap.put(Float.NaN, "0 11111111 10000000000000000000000");
		floatStringMap.put(-1.0f, "1 01111111 00000000000000000000000");
		floatStringMap.put(Float.NEGATIVE_INFINITY, "1 11111111 00000000000000000000000");
		floatStringMap.put(+0.0f, "0 00000000 00000000000000000000000");
		floatStringMap.put(-0.0f, "1 00000000 00000000000000000000000");
		floatStringMap.put(-Float.MAX_VALUE, "1 11111110 11111111111111111111111");
		floatStringMap.put(+Float.MIN_VALUE, "0 00000000 00000000000000000000001");
		floatStringMap.put(-Float.MIN_VALUE, "1 00000000 00000000000000000000001");
	}

	public static String doubleToIEEE_754(double number) {
		System.out.println(number);
		if (doubleStringMap.containsKey(number)) {
			return doubleStringMap.get(number);
		}
		var intBits = Double.doubleToLongBits(Math.abs(number));
		var binary = Long.toBinaryString(intBits);
		return ((number < 0) ? "1 " : "0 " + binary.substring(0, 11) + " " + binary.substring(11));
	}

	public static String floatToIEEE_754(float number) {
		System.out.println(number);
		if (floatStringMap.containsKey(number)) {
			return floatStringMap.get(number);
		}
		var intBits = Float.floatToIntBits(Math.abs(number));
		var binary = Integer.toBinaryString(intBits);
		return ((number < 0) ? "1 " : "0 " + binary.substring(0, 8) + " " + binary.substring(8));
	}
}
