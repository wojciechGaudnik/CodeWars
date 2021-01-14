package alternate_capitalization.kyu7;

public class Solution {

	public static String[] capitalize(String s){
		var first = new StringBuilder();
		var second = new StringBuilder();
		var p = true;
		for (var one : s.split("")) {
			if (p) {
				first.append(one.toUpperCase());
				second.append(one.toLowerCase());
				p = false;
			} else {
				first.append(one.toLowerCase());
				second.append(one.toUpperCase());
				p = true;
			}
		}
		return new String[]{first.toString(), second.toString()};
	}
}
   
