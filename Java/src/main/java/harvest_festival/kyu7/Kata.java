package harvest_festival.kyu7;

public class Kata {

	public static String plant(char seed, int water, int fert, int temp) {
		if (temp < 20 || temp > 30) {
			return "-".repeat(water * water) + seed;
		}
		return ("-".repeat(water) + String.valueOf(seed).repeat(fert)).repeat(water);
	}
}
