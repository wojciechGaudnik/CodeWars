package zebulan_s_nightmare.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class ZebulansNightmare {
	public static String zebulansNightmare(final String functionName) {
		if (functionName.isEmpty()) {
			return "";
		}
		return Character.toLowerCase(functionName.charAt(0))
				+ Arrays.stream(functionName.split("_"))
				.map(s -> Character.toUpperCase(s.charAt(0)) + s.substring(1))
				.collect(Collectors.joining()).substring(1);
	}

}
