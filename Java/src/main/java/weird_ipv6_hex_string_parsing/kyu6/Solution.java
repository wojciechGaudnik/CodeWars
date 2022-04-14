package weird_ipv6_hex_string_parsing.kyu6;

import java.util.Arrays;
import java.util.stream.Collectors;

class Solution {
	public static String parseIPv6(String ip) {
		return Arrays.stream(
						ip.split("[^0-9A-F]"))
				.mapToLong(s -> s.chars().mapToLong(c -> Long.parseLong(Character.toString(c), 16)).sum())
				.mapToObj(String::valueOf)
				.collect(Collectors.joining());
	}
}
