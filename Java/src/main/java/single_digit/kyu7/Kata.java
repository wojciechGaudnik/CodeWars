package single_digit.kyu7;

class Kata {

	static int singleDigit(int n) {
		if (n <= 9) {
			return n;
		}
		return singleDigit((int) Integer.toBinaryString(n).chars().mapToObj(c -> (char) c).filter(c -> c == '1').count());
	}

}