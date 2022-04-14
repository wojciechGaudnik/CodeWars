package miles_per_gallon_to_kilometers_per_liter.kyu8;

public class Converter {

	public static float mpgToKPM(final float mpg) {
		return (float) (Math.round((mpg * 1.609344) / 4.54609188 * 100.0) / 100.0);
	}
}
