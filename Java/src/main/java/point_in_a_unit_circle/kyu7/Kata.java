package point_in_a_unit_circle.kyu7;

public class Kata {

	public static boolean pointInCircle(double x, double y) {
		return Math.pow(x, 2) + Math.pow(y, 2) < 1;
	}
}
