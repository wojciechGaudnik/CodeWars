package introToArt.kyu6;

import java.util.Arrays;

public class Kata {
	public static void main(String[] args) {
		System.out.println(String.join("\n", getW(1)));
	}

	public static String[] getW(int height) {
		if (height <= 1) {
			return new String[0];
		}
		var length = ((height - 1) * 4) + 1;
		var answerPart = new StringBuilder[height];
		for (var y = 0; y < answerPart.length; y++) {
			answerPart[y] = new StringBuilder(" ".repeat(length));
		}
		var add = 1;
		var y = 0;
		for (var x = 0; x < length; x++) {
			if (y >= height) {
				add = -1;
				y += add - 1;
			}
			else if (y < 0) {
				add = 1;
				y += add + 1;
			}
			answerPart[y] = answerPart[y].replace(x, x + 1, "*");
			y += add;
		}
		return Arrays.stream(answerPart).map(StringBuilder::toString).toArray(String[]::new);
	}

}
