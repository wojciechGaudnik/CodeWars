package aerial_firefighting.kyu7;

import java.util.Arrays;

class Solution {

	public static int waterbombs(String fire, int w){
		return Arrays.stream(fire.split("Y"))
				.mapToInt(s -> s.length() % w == 0 ? s.length() / w: (s.length() / w) + 1)
				.sum();
	}

}
