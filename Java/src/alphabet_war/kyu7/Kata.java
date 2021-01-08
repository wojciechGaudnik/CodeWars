package alphabet_war.kyu7;

import java.util.HashMap;

public class Kata {

	public static String alphabetWar(String fight){
		var letters = new HashMap<Character, Integer>(){{
			put('w', 4);
			put('p', 3);
			put('b', 2);
			put('s', 1);
			put('m', -4);
			put('q', -3);
			put('d', -2);
			put('z', -1);
		}};
		var answer = fight.chars().mapToObj(c -> (char)c).mapToInt(c -> letters.getOrDefault(c, 0)).sum();
		if (answer == 0) {
			return "Let's fight again!";
		}
		return (answer > 0) ?"Left side wins!" : "Right side wins!";
	}
}
