package battle_of_the_characters_easy.kyu7;

public class BattleOfTheCharacters {

	public static String battle(final String x, final String y) {
		var xSum = x.chars().map(c -> c - 64).sum();
		var ySum = y.chars().map(c -> c - 64).sum();
		if (xSum == ySum) {
			return "Tie!";
		}
		return (xSum > ySum) ? x : y;
	}
}
