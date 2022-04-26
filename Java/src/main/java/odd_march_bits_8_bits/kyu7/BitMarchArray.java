package odd_march_bits_8_bits.kyu7;

public class BitMarchArray {

	public static int[][] BitMarch(int n) {
		var answer = new int[9 - n][];
		var e = 0;
		while (e < 9 - n) {
			var st = "0".repeat(8 - n - e) + "1".repeat(n) + "0".repeat(e);
			answer[e++] = st.chars().mapToObj(Character::getNumericValue).mapToInt(Integer::intValue).toArray();
		}
		return answer;
	}

}
