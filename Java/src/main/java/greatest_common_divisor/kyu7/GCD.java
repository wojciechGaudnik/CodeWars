package greatest_common_divisor.kyu7;

public class GCD {

	public static int compute(int x, int y) {
		while (x != y) {
			if (x > y) x -= y;
			else y -= x;
			}
		return y;
	}
}
   
