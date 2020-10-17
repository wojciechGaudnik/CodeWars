package pokerhand_straight_or_not.kyu7;

import java.util.ArrayList;
import java.util.stream.Collectors;

public class PokerHand {

	public static boolean IsStraight(ArrayList<Integer> cards) {
		if (cards.size() < 5 || cards.size() > 7) return false;
		if (cards.contains(14)) cards.add(1);
		var cardsList = cards.stream().sorted().distinct().collect(Collectors.toList());
		var count = 1;
		for (int i = 0; i < cardsList.size() - 1; i++) {
			if (cardsList.get(i) + 1 == cardsList.get(i + 1)) count++;
			else count = 1;
			if (count == 5) return true;
		}
		return false;
	}
}
   
