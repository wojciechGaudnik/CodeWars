package simple_fun_319_number_and_IP_address;

import java.util.Arrays;
import java.util.stream.Collectors;

public class NumberAndIPAddress {

	public static String numberAndIPaddress(String s) {
		if (s.contains(".")) {
			var arr = s.split("\\.");
			StringBuilder stringBuilder = new StringBuilder();
			for (var one : arr) {
				var binary = Long.toBinaryString(Long.parseLong(one));
				stringBuilder.append("00000000".substring(binary.length())).append(binary);
			}
			return String.valueOf(Long.parseLong(stringBuilder.toString(), 2));
		} else {
			var binary = Long.toBinaryString(Long.parseLong(s));
			var fullBinary = "00000000000000000000000000000000".substring(binary.length()) + binary;
			var arr = fullBinary.split("(?<=\\G........)");
			return Arrays.stream(arr).mapToLong(i -> Long.parseLong(i, 2)).mapToObj(String::valueOf).collect(Collectors.joining("."));
		}
	}
}
