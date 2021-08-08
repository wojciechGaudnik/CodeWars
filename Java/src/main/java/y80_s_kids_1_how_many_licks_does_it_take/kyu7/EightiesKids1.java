package y80_s_kids_1_how_many_licks_does_it_take.kyu7;

import java.util.Map;

public class EightiesKids1 {
	public static String totalLicks(Map<String, Integer> env) {
		var averageLicks = 252;
		var sum = env.values().stream().mapToInt(i -> i).sum();
		var hardest = env.entrySet().stream().filter(e -> e.getValue() > 0).max(Map.Entry.comparingByValue());
		var firstPart = String.format("It took %s licks to get to the tootsie roll center of a tootsie pop.", averageLicks + sum);
		var secondPart = (hardest.isPresent() ? String.format(" The toughest challenge was %s.", hardest.get().getKey()) : "");
		return firstPart + secondPart;
	}
}
