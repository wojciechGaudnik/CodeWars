package travelling_on_a_grid.kyu6;

class Solution {
	public static int travelChessboard(String s) {
		var cords = s.replace(")(", ",").replace("(", "").replace(")", "").split(",");
		var x1 = Integer.parseInt(cords[0].split(" ")[0]);
		var y1 = Integer.parseInt(cords[0].split(" ")[1]);
		var x2 = Integer.parseInt(cords[1].split(" ")[0]);
		var y2 = Integer.parseInt(cords[1].split(" ")[1]);
		return count(x1, y1, x2, y2);
	}


	private static int count(int x1, int y1, int x2, int y2) {
		if (x1 == x2 && y1 == y2) return 1;
		if (x1 > x2 || y1 > y2)	return 0;
		return count(x1 + 1, y1, x2, y2) + count(x1, y1 + 1, x2, y2);
	}

}
