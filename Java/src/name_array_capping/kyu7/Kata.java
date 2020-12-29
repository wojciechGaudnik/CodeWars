package name_array_capping.kyu7;

import java.util.Arrays;

public class Kata {

	public static String[] capMe(String[] strings){
		return Arrays.stream(strings).map(s -> Character.toTitleCase(s.charAt(0)) + s.substring(1).toLowerCase()).toArray(String[]::new);
	}
}
