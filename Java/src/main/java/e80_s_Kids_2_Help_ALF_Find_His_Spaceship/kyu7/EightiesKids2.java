package e80_s_Kids_2_Help_ALF_Find_His_Spaceship.kyu7;

public class EightiesKids2 {
	public static String findSpaceship(String map) {
		var x = 0;
		var y = 1;
		var split = map.split("\n");
		for (var oneLine : split) {
			x = oneLine.indexOf("X");
			if (x >= 0) {
				return String.format("[%d, %d]", x, split.length - y);
			}
			y++;
		}
		return "Spaceship lost forever.";
	}
}
