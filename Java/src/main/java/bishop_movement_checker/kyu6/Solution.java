package bishop_movement_checker.kyu6;

import java.util.HashSet;

class Solution {
	public static boolean bishop(String positionStart, String positionEnd, int n) {
		if (positionStart.equals(positionEnd)) {
			return true;
		}
		var firstOne = new HashSet<String>();
		var secondOne = new HashSet<String>();
		calculate(positionStart, firstOne);
		calculate(positionEnd, secondOne);
		if (firstOne.contains(positionEnd) && n >= 1) {
			return true;
		}
		return firstOne.stream().anyMatch(secondOne::contains) && n >= 2;
	}

	private static void calculate(String positionStart, HashSet<String> firstOne) {
		firstOne.add(positionStart);
		var lx = positionStart.charAt(0);
		var ly = Character.getNumericValue(positionStart.charAt(1));
		var rx = positionStart.charAt(0);
		var ry = Character.getNumericValue(positionStart.charAt(1));
		right(firstOne, lx, ly, rx, ry);
		left(firstOne, lx, ly, rx, ry);
	}

	private static void right(HashSet<String> firstOne, char lx, int ly, char rx, int ry) {
		while (lx >= 'a' || ly >= 1 || rx <= 'h' || ry <= 8) {
			lx--;
			ly--;
			rx++;
			ry++;
			firstOne.add(String.valueOf(lx) + ly);
			firstOne.add(String.valueOf(rx) + ry);
		}
	}

	private static void left(HashSet<String> firstOne, char lx, int ly, char rx, int ry) {
		while (lx <= 'h' || ly >= 1 || rx <= 'q' || ry <= 8) {
			lx++;
			ly--;
			rx--;
			ry++;
			firstOne.add(String.valueOf(lx) + ly);
			firstOne.add(String.valueOf(rx) + ry);
		}
	}
}
