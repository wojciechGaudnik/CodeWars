package the_old_switcheroo.kyu7;

public class Kata {

	public static String vowel2Index(String s) {
		var valves = "aeiou";
		StringBuilder answer = new StringBuilder();
		for (var i = 0; i < s.length(); i++) {
			if (valves.contains(s.substring(i, i+1).toLowerCase())){
				answer.append(i + 1);
				continue;
			}
			answer.append(s.charAt(i));
		}
		return answer.toString();
	}
}
