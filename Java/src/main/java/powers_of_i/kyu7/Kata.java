package powers_of_i.kyu7;

public class Kata {
	public static String pofi(int n) {
		return new String[]{"1", "i", "-1", "-i"}[n % 4];
	}
}
