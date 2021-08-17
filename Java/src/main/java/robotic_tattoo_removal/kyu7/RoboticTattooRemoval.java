package robotic_tattoo_removal.kyu7;

import java.util.Arrays;

public class RoboticTattooRemoval {
	public static String[][] robot(String[][] skinScan) {
		return Arrays.stream(skinScan)
				.map(l -> Arrays.stream(l)
						.map(s -> s.replace("X", "*"))
						.toArray(String[]::new))
				.toArray(String[][]::new);
	}
}
