package Pyramid;

public class Pyramid{

	public static String watchPyramidFromTheSide(String characters){
		if(characters == null ) return null;
		if(characters.length() == 0) return "";
		StringBuilder out = new StringBuilder();
		characters = new StringBuilder(characters).reverse().toString();
		int length = characters.length() * 2 - 1;
		for (int i = 0; i <= characters.length() - 1; i++) {
			StringBuilder part = new StringBuilder(" ".repeat(length));
			String bricks = String.valueOf(characters.charAt(i)).repeat(((i + 1) * 2) - 1);
			part.replace((length - bricks.length()) / 2, (length + bricks.length()) / 2, bricks);
			out.append(part).append("\n");
		}
		out.deleteCharAt(out.length() - 1);
		return out.toString();
	}

	public static String watchPyramidFromAbove(String characters){
		if(characters == null ) return null;
		if(characters.length() == 0) return "";
		int length = characters.length() * 2 - 1;
		char[][] above = new char[length][length];
		int i = 0;
		while (i < characters.length()){
			int start = i;
			int stop = length - i;
			for (int y = 0; y < length; y++) {
				for (int x = 0; x < length ; x++) {
					if (y >= start && y < stop && x >= start && x < stop) {
						above[y][x] = characters.charAt(i);
					}
				}
			}
			i++;
		}
		StringBuilder out = new StringBuilder();
		for (char[] row : above) {
			out.append(row).append("\n");
		}
		return out.deleteCharAt(out.length() - 1).toString();
	}

	public static int countVisibleCharactersOfThePyramid(String characters){
		if(characters == null || characters.length() == 0) return -1;

		return (int) Math.pow((characters.length() * 2 - 1), 2);
	}

	public static int countAllCharactersOfThePyramid(String characters){
		if(characters == null || characters.length() == 0) return -1;
		int length = characters.length() * 2 - 1;
		int out = 0;
		while (length > 0) {
			out += Math.pow(length, 2);
			length -= 2;
		}
		return out;
	}
}
