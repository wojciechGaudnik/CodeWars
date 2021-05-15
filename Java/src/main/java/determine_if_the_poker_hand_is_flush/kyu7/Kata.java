package determine_if_the_poker_hand_is_flush.kyu7;

public class Kata {
	public static boolean CheckIfFlush(String[] cards) {
		var color = cards[0].charAt(cards[0].length() - 1);
		for (var one : cards) {
			if (one.charAt(one.length() - 1) != color) {
				return false;
			}
		}
		return true;
	}

}
