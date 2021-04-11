package a_wolf_in_sheep_s_clothing.kyu8;

public class ZywOo {

	public static String warnTheSheep(String[] array) {
		for (var i = 0; i < array.length - 1; i++) {
			if (array[i].equals("wolf")) {
				return String.format("Oi! Sheep number %d! You are about to be eaten by a wolf!", array.length - i - 1);
			}
		}
		return "Pls go away and stop eating my sheep";
	}
}
