package simple_fibonacci_strings.kyu7;

public class Solution {
	public static String solve(int n) {
		var f0 = "0";
		var f1 = "01";
		if (n == 0) {
			return f0;
		}
		if (n == 1) {
			return f1;
		}
		var f2 = "";
		for (var i = 1; i < n; i++) {
			f2 = f1 + f0;
			f0 = f1;
			f1 = f2;
		}
		return f2;
	}
}
