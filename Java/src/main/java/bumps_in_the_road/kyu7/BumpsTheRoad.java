package bumps_in_the_road.kyu7;

public class BumpsTheRoad {

	public static String bumps(final String road) {
		return ((int) road.chars().mapToObj(c -> (char) c).filter(c -> c == 'n').count() > 15) ? "Car Dead" : "Woohoo!";
	}
}
