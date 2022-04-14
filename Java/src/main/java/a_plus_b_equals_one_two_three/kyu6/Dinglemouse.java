package a_plus_b_equals_one_two_three.kyu6;

public class Dinglemouse {
	private Dinglemouse() {
	}

	public static long int123(int a) {
		if ((123 - a) >= 0) {
			return (123 - a);
		}
		long b = 9223372036854775807L;
		b -= a - 124;
		return b;
	}
}
   
