package speed_control.kyu7;

public class GpsSpeed {

	public static int gps(int s, double[] x) {
		if (x.length <= 1) return 0;
		double maxDist = 0;
		for (var i = 1; i < x.length; i++) {
			if (x[i] - x[i - 1] > maxDist) {
				maxDist = x[i] - x[i - 1];
			}
		}
		return (int) Math.floor((3600 * (maxDist)) / s);
	}
}
   
