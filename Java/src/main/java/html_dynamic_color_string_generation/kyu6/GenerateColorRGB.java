package html_dynamic_color_string_generation.kyu6;

import java.util.Random;
import java.util.function.Function;

public class GenerateColorRGB {

	private static Function<Random, String> random = v -> {
		var rgb = new StringBuilder().append("#");
		while (rgb.length() != 7) {
			var hex = Integer.toHexString(v.nextInt(256));
			rgb.append("00".substring(hex.length())).append(hex);
		}
		return rgb.toString();
	};

	public static String generateColor(Random r) {
		return random.apply(r);
	}
}
