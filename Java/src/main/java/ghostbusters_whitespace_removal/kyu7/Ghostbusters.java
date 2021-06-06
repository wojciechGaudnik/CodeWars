package ghostbusters_whitespace_removal.kyu7;

public class Ghostbusters {

	public static String ghostBusters(String building) {
		if (!building.contains(" ")) {
			return "You just wanted my autograph didn't you?";
		}
		return building.replaceAll(" ", "");
	}
}