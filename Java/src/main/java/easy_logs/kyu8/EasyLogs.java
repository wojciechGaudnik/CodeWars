package easy_logs.kyu8;

public class EasyLogs {

	public static double logs(double x, double a, double b) {
		return logWithBase(a, x) + logWithBase(b, x);
	}

	private static double logWithBase(double x, double base) {
		return Math.log(x) / Math.log(base);
	}
}
