package kingdoms_ep1_jousting.kyu6;

class Kata {
	static String[] joust(String[] listField, int vKnightLeft, int vKnightRight) {
		if (vKnightLeft == 0 && vKnightRight == 0) {
			return listField;
		}
		var length = listField[0].length();
		var leftKnight = 2;
		var rightKnight = length - 3;
		while (leftKnight < rightKnight) {
			leftKnight += vKnightLeft;
			rightKnight -= vKnightRight;
		}
		var leftKnightView = " ".repeat(leftKnight - 2) + "$->" + " ".repeat(length - leftKnight - 1);
		var rightKnightView = " ".repeat(rightKnight) + "<-P" + " ".repeat(length - (rightKnight + 3));
		return new String[]{leftKnightView, rightKnightView};
	}
}
