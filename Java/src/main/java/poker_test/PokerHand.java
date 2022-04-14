package poker_test;

import java.util.*;
import java.util.stream.*;

public class PokerHand implements Comparable<PokerHand> {

	public static void main(String[] args) {
		var player1 = new PokerHand("2H 3H 4H 5H 6H");
		var player2 = new PokerHand("KS AS TS QS JS");
		System.out.println(player1.compareTo(player2));
		System.out.println("test4324");
	}

	private String hand;
	private int rank;
	private String v;

	public int compareTo(PokerHand other) {
		if (other.rank - rank != 0) {
			return other.rank - rank;
		} else {
			return other.v.compareTo(v);
		}
	}

	public PokerHand(String hand) {
		this.hand = hand;
		hand = hand.replaceAll("T", "a").replaceAll("J", "b").replaceAll("Q", "c").replaceAll("K", "d").replaceAll("A", "e");
		hand = Arrays.stream(hand.split(" ")).sorted().collect(Collectors.joining(" "));
		v = "" + hand.charAt(12) + hand.charAt(9) + hand.charAt(6) + hand.charAt(3) + hand.charAt(0);
		boolean flush = hand.matches(".(\\w) .\\1 .\\1 .\\1 .\\1");
		boolean poker = hand.matches(".*(\\w)\\w \\1\\w \\1\\w \\1\\w.*");
		boolean full1 = hand.matches(".*(\\w)\\w \\1\\w (\\w)\\w \\2\\w \\2\\w.*");
		boolean full2 = hand.matches(".*(\\w)\\w \\1\\w \\1\\w (\\w)\\w \\2\\w.*");
		boolean drill = hand.matches(".*(\\w)\\w \\1\\w \\1\\w.*");
		boolean twopair = hand.matches(".*(\\w)\\w \\1\\w (\\w)\\w \\2\\w.*");
		boolean pair = hand.matches(".*(\\w)\\w \\1\\w.*");
		boolean straight = hand.matches("2..3..4..5..6.") ||
				hand.matches("3..4..5..6..7.") ||
				hand.matches("4..5..6..7..8.") ||
				hand.matches("5..6..7..8..9.") ||
				hand.matches("6..7..8..9..a.") ||
				hand.matches("7..8..9..a..b.") ||
				hand.matches("8..9..a..b..c.") ||
				hand.matches("9..a..b..c..d.") ||
				hand.matches("a..b..c..d..e.") ||
				hand.matches("2..3..4..5..e.");
		if (straight && flush) {
			v = v.replaceAll("e5432", "54321");
			rank = 8;
		} else if (poker) {
			rank = 7;
		} else if (full1) {
			rank = 6;
		} else if (full2) {
			v = v.substring(3, 5) + v.substring(0, 3);
			rank = 6;
		} else if (flush) {
			rank = 5;
		} else if (straight) {
			v = v.replaceAll("e5432", "54321");
			rank = 4;
		} else if (drill) {
			v = v.replaceAll("(.*)(\\w)\\2\\2(.*)", "$2$2$2$1$3");
			rank = 3;
		} else if (twopair) {
			v = v.replaceAll("(.*)(\\w)\\2(\\w)\\3(.*)", "$2$2$3$3$1$4");
			rank = 2;
		} else if (pair) {
			v = v.replaceAll("(.*)(\\w)\\2(.*)", "$2$2$1$3");
			rank = 1;
		} else {
			rank = 0;
		}
	}
}