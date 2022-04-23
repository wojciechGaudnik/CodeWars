package robinson_crusoe.kyu7;

class RobinsonCrusoe {

	public static double[] crusoe(int n, double d, int ang, double distmult, double angmult) {
		var x = 0D;
		var y = 0D;
		var angle = Math.toRadians(ang);
		for (; n > 0; n--) {
			x += d * Math.cos(angle);
			y += d * Math.sin(angle);
			angle *= angmult;
			d *= distmult;
		}
		return new double[]{x, y};
	}

}