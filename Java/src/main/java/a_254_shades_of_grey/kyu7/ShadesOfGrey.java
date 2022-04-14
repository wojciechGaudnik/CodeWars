package a_254_shades_of_grey.kyu7;

import java.util.stream.IntStream;

public class ShadesOfGrey {
	static String[] shadesOfGrey(int num) {
		if (num < 1) {
			return new String[0];
		}
		return IntStream.range(1, (num > 254) ? 255 : num + 1).mapToObj(Integer::toHexString)
				.map(e -> (e.length() < 2) ? "#0" + e + "0" + e + "0" + e : "#" + e + e + e).toArray(String[]::new);
	}
}
