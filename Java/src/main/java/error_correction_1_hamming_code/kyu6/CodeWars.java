package error_correction_1_hamming_code.kyu6;

import java.util.stream.Collectors;

public class CodeWars {

	public String encode(String text) {
		var answer = new StringBuilder();
		for (var one : text.toCharArray()) {
			var asci = (int) one;
			var binary = String.format("%8s", Integer.toBinaryString(asci)).replace(' ', '0');
			var triple = binary.chars()
					.mapToObj(e -> String.valueOf((char) e))
					.map(e -> e + e + e)
					.collect(Collectors.joining(""));
			answer.append(triple);
		}
		return answer.toString();
	}

	public String decode(String bits) {
		var answer = new StringBuilder();
		var clean = new StringBuilder();
		for (var i = 0; i <= bits.length() - 3; i += 3) {
			if (bits.substring(i, i + 3).chars().filter(c -> c == '0').count() >= 2) {
				clean.append('0');
			} else {
				clean.append('1');
			}
		}
		var bitsBy8 = clean.toString().split("(?<=\\G........)");
		for (var one : bitsBy8) {
			answer.append((char) Integer.parseInt(one, 2));
		}
		return answer.toString();
	}
}
