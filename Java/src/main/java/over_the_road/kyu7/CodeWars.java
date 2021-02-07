package over_the_road.kyu7;

public class CodeWars {

	public static long overTheRoad(long address, long n) {
		if (address % 2 == 1) {
			long line = (address / 2) + 1;
			return (-2 * (line - 1)) + 2 * n;
		} else {
			long line = (2 * n - address) / 2 + 1;
			return 2 * (line - 1) + 1;
		}
	}
}
