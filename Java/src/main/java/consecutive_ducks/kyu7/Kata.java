
package consecutive_ducks.kyu7;

public class Kata {

	public static boolean consecutiveDucks(int n, Object... test) {
		for (int i = 1; Math.pow(2, i) <= n; i++) {
			if (Math.pow(2, i) == n) {
				return false;
			}
		}
		return true;
	}
}
