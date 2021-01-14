package Dinglemouse2;

public class Dinglemouse {

	public static double zigZagCamel(final double d, final double h) {
		double high = h;
		double dBase = d;
		double degrees30d = 30.0;
		double radians30r = Math.toRadians(degrees30d);
		double beta = Math.atan((h / d));  //todo <--- ok !!!
		if (Math.toDegrees(beta) < 30.0) {
			return Math.sqrt(Math.pow(d, 2) + Math.pow(h, 2));
		}
		double trip = 0;
		double hp;
		while (high > 0.000001) {
			hp = Math.tan(radians30r) * dBase;
			hp = Math.tan(radians30r) * dBase;
			trip += Math.sqrt(Math.pow(dBase, 2) + Math.pow(hp, 2));
			dBase -= (hp / Math.tan(beta));
			high -= hp;
		}
		return trip;
	}

	public static double zigZagCamel2(final double d, final double h) {
		double high = h;
		double dBase = d;
		double degrees30d = 30.0;
		double radians30r = Math.toRadians(degrees30d);
		double beta = Math.toDegrees(Math.atan((h / d)));  //todo <--- ok !!!
		if (beta < 30.0) {
			return Math.sqrt(Math.pow(d, 2) + Math.pow(h, 2));
		}
		double trip = 0;
		double hp;
		hp = Math.tan(radians30r) * dBase;
		trip += Math.sqrt(Math.pow(dBase, 2) + Math.pow(hp, 2));
		dBase -= (hp / Math.tan(Math.toRadians(beta)));
		return trip;
	}

}
