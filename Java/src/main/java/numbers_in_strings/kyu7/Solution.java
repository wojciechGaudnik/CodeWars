package numbers_in_strings.kyu7;

import java.util.regex.Pattern;

public class Solution {
	public static int solve(String s) {
		var pattern = Pattern.compile("\\d+");
		var matcher = pattern.matcher(s);
		var max = 0;
		while (matcher.find()) {
			var maxBuff = Integer.parseInt(matcher.group());
			if (max < maxBuff)
				max = maxBuff;
			System.out.println(matcher.group());
		}
		return max;
	}
}
