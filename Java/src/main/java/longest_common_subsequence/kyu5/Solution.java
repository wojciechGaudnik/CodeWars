package longest_common_subsequence.kyu5;

public class Solution {

	public static String lcs(String x, String y) {
		System.out.println(x + "<--->" + y);
		if (y.length() > x.length()) {
			var buff = y;
			y = x;
			x = buff;
		}
		x = x.replaceAll("[^" + y + "]", "");
		var answer = new StringBuilder();
		var xI = 0;
		var yI = 0;
		while (yI < y.length() && xI < x.length()) {
			if (x.charAt(xI) == y.charAt(yI)) {
				answer.append(x.charAt(xI));
				xI++;
				yI++;
				continue;
			}
			xI++;
			if (xI == x.length()) {
				xI = ++yI;
			}
		}
		return answer.toString();
	}
}
   
