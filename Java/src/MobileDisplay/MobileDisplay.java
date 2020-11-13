package MobileDisplay;

public class MobileDisplay {

	public static String mobileDisplay(int n, int p){
		if (n < 15 && p > 70) {
			return "-";
		}
		System.out.println(n + "  " +  p);
		int width = Math.max(n, 20);
		int height = (int) (n * ((double) (Math.max(p, 20)) / 100));
		if ((((double)height * 100) / width) < 30) {
			height = (int)(0.3 * width);
		}
		int halfVertical = (int)Math.round((double) height / 2) + 1;
		int halfHorizontal = (width / 2) - 5;
		System.out.println(height + " <---height");
		System.out.println(halfVertical + " <---halfVertical");
		System.out.println(halfHorizontal);
		StringBuilder board = new StringBuilder("*".repeat(width)).append("\n");
		while (height-- > 0) {
			if (height == halfVertical) {
				board
						.append("*")
						.append(" ".repeat(halfHorizontal))
						.append("CodeWars")
						.append(" ".repeat(width - halfHorizontal - 10))
						.append("*\n");
				continue;
			}
			if (height == 2) {
				board
						.append("* Menu")
						.append(" ".repeat(width - 16))
						.append("Contacts *\n")
						.append("*".repeat(width));
				break;
			}
			board
					.append("*")
					.append(" ".repeat(width - 2))
					.append("*\n");
		}
		return board.toString();
	}
}

