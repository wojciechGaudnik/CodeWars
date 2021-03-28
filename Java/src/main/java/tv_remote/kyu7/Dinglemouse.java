package tv_remote.kyu7;

public class Dinglemouse {
	public static int tvRemote(final String word) {
		var keyword = new String[5];
		keyword[0] = "abcde123";
		keyword[1] = "fghij456";
		keyword[2] = "klmno789";
		keyword[3] = "pqrst.@0";
		keyword[4] = "uvwxyz_/";
		var answer = 0;
		var x1 = 1;
		var y1 = 1;
		for (var one : word.toCharArray()) {
			var x2 = 0;
			var y2 = 0;
			for (var i = 0; i < keyword.length; i++) {
				if (keyword[i].contains(String.valueOf(one))) {
					x2 = keyword[i].indexOf(String.valueOf(one)) + 1;
					y2 = i + 1;
					answer += Math.abs(x1 - x2) + Math.abs(y1 - y2) + 1;
					x1 = x2;
					y1 = y2;
					break;
				}
			}
		}
		return answer;
	}
}
