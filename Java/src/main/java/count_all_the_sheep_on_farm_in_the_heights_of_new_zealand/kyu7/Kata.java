package count_all_the_sheep_on_farm_in_the_heights_of_new_zealand.kyu7;

import java.util.Arrays;

public class Kata {

	public static int lostSheeps(int[] fridayNightCounting, int[] saturdayNightCounting, int sheepsTotal) {
		var test = sheepsTotal - (Arrays.stream(fridayNightCounting).sum() + Arrays.stream(saturdayNightCounting).sum());
		System.out.println(Arrays.stream(saturdayNightCounting).sum());
		return test;
	}
}
