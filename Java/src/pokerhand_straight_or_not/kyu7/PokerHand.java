package pokerhand_straight_or_not.kyu7;

import java.util.ArrayList;
import java.util.stream.Collectors;

public class PokerHand {

	public static void main(String[] args) {
		ArrayList<Integer> hand = new ArrayList<Integer>();
		hand.add(7);
		hand.add(3);
		hand.add(5);
		hand.add(4);
		hand.add(6);
		hand.add(4);
		hand.add(2);
		System.out.println(IsStraight(hand));

	}
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
   
