package resistor_color_codes.kyu7;

import java.util.HashMap;
import java.util.Map;

public class DecodeResistorColors {
	private static Map<String, Integer> map = new HashMap<>() {{
		put("black", 0);
		put("brown", 1);
		put("red", 2);
		put("orange", 3);
		put("yellow", 4);
		put("green", 5);
		put("blue", 6);
		put("violet", 7);
		put("gray", 8);
		put("white", 9);
		put("gold", 5);
		put("silver", 10);
	}};


	public static String decodeResistorColors(String bands) {
		var bandsArray = bands.split(" ");
		var digits = map.get(bandsArray[0]) * 10 + map.get(bandsArray[1]);
		var ohms = digits * Math.pow(10, map.get(bandsArray[2]));
		var precision = ((bandsArray.length == 4) ? map.get(bandsArray[3]) : "20") + "%";
		if (ohms < 1000) {
			return (int) ohms + " ohms, " + precision;
		} else if (ohms < 1000000) {
			return ((ohms / 1000) + "k ohms, " + precision).replaceAll("\\.0", "");
		} else {
			return ((ohms / 1000000) + "M ohms, " + precision).replaceAll("\\.0", "");
		}
	}

}
