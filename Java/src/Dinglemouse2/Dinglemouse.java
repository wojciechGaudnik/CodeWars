package Dinglemouse2;

public class Dinglemouse {

	public static void main(String[] args) {
		System.out.println(zigZagCamel(152.20753825185588, 90.37998729508298));
		System.out.println("180.75997164588466");



//		System.out.println(Math.sqrt(125));

	}

	//		System.out.println(d + "   " + h);
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
//		System.out.println(d + "   " + h);
		double high = h;
		double dBase = d;
//		System.out.println(Math.sqrt(Math.pow(10, 2) + Math.pow(10, 2))); //todo <--- ok !
		double degrees30d = 30.0;
		double radians30r = Math.toRadians(degrees30d);
		double beta = Math.toDegrees(Math.atan((h / d)));  //todo <--- ok !!!
//		System.out.println(beta + " <--- beta");
		if (beta < 30.0) {
			return Math.sqrt(Math.pow(d, 2) + Math.pow(h, 2));
		}
		double trip = 0;
		double hp;
		hp = Math.tan(radians30r) * dBase;
//		System.out.println(Math.tan(radians30r) * dBase + " <--- hp"); // todo <--- ok !!!
		trip += Math.sqrt(Math.pow(dBase, 2) + Math.pow(hp, 2));
//		System.out.println(Math.sqrt(Math.pow(dBase, 2) + Math.pow(hp, 2)) + "<--- trip");  //todo <--- OK !!
		dBase -= (hp / Math.tan(Math.toRadians(beta)));
//		System.out.println(dBase + " <--- dbase");  //todo <--- ok !!



//		while (high > 0.00001) {
//			System.out.println(trip);
//			h1 = Math.tan(radians30r) * dBase;
//			high -= h1;
//			trip += Math.sqrt(Math.pow(dBase, 2) + Math.pow(h1, 2));
//			dBase = (h / Math.tan(beta));
//		}
		return trip;
	}

}
