package password_system.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Kata {
	public static String helpZoom(final int[] key) {
		var key1String = Arrays.stream(key).mapToObj(String::valueOf).collect(Collectors.joining());
		var key2String = new StringBuilder(Arrays.stream(key).mapToObj(String::valueOf).collect(Collectors.joining())).reverse().toString();
		return key1String.equals(key2String) ? "Yes" : "No";
	}
}
