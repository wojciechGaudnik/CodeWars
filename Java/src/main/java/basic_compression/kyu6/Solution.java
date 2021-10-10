package basic_compression.kyu6;

import java.util.regex.Pattern;

class Solution {
	public static void main(String[] args) {
		System.out.println("test");
	}
	public static String compress(String s) {
		if (!Pattern.compile("(.)\\1{2,}").matcher(s).find()) return s;
		var answer = new StringBuilder();
		var pattern = Pattern.compile("(.)\\1*");
		var matcher= pattern.matcher(s);
		while (matcher.find()) {
			answer.append("[").append(matcher.group().length()).append(",\"").append(matcher.group().charAt(0)).append("\"],");
		}
		answer.deleteCharAt(answer.length() - 1);
		return "[" + answer + "]";
	}

	public static String decompress(String s) {
		System.out.println(s + "<---");
		if (!s.contains("[")) return s;
		var answer = new StringBuilder();
		var pattern = Pattern.compile("\\[[^\\[^\\]]*]");
		var matcher = pattern.matcher(s);
		while (matcher.find()) {
			var multiplier = Integer.parseInt(matcher.group().split(",")[0].substring(1));
			var character = matcher.group().split("\\d,")[1].substring(1).substring(0, 1);
			answer.append(character.repeat(multiplier));
		}
		return answer.toString();
	}
}
