package delta_bits.kyu7;


public class DeltaBits {

	public static int convertBits(int a, int b) {
		var aString = String.format("%32s", Integer.toBinaryString(a)).replace(' ', '0');
		var bString = String.format("%32s", Integer.toBinaryString(b)).replace(' ', '0');
		var answer = 0;
		for (var i = 0; i < aString.length(); i++) {
			if (aString.charAt(i) != bString.charAt(i)) {
				answer++;
			}
		}
		return answer;
	}
}
