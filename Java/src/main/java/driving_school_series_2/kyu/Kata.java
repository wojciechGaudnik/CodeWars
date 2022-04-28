package driving_school_series_2.kyu;

public class Kata {

	public static int cost(int mins) {
		return (int) (30 + (mins > 65 ? Math.ceil((double) (mins - 65) / 30) : 0) * 10);
	}

}