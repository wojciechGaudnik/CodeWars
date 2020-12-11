package red_knight.kyu7;

public class CodeWars {

	public static void main(String[] args) {
		var test = redKnight(0, 8);
		System.out.println(test.color);
		System.out.println(test.distance);

		test = redKnight(0, 7);
		System.out.println(test.color);
		System.out.println(test.distance);

		test = redKnight(1, 6);
		System.out.println(test.color);
		System.out.println(test.distance);

		test = redKnight(1, 5);
		System.out.println(test.color);
		System.out.println(test.distance);
	}

	public static PawnDistance redKnight(int knight, long pawn) {
		if (knight == 0 && pawn % 2 == 0) return new PawnDistance("White", pawn * 2);
		if (knight == 0 && pawn % 2 == 1) return new PawnDistance("Black", pawn * 2);
		if (knight == 1 && pawn % 2 == 0) return new PawnDistance("Black", pawn * 2);
		return new PawnDistance("White", pawn * 2);
	}


	static class PawnDistance {
		private String color;
		private long distance;
		public PawnDistance(String s, long d) {
			color = s;
			distance = d;
		}
	}

}
