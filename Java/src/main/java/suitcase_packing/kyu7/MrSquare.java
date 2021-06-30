package suitcase_packing.kyu7;

public class MrSquare {

	public static Boolean fit_in(int a, int b, int m, int n) {
		return ((a + b) <= m && Math.max(a, b) <= n) || ((a + b) <= n && Math.max(a, b) <= m);
	}
}
