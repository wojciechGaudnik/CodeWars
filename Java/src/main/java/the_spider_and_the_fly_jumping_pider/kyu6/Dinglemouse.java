package the_spider_and_the_fly_jumping_pider.kyu6;

public class Dinglemouse {

	public static double spiderToFly(final String spider, final String fly) {
		var spiderL = spider.charAt(0);
		var flyL = fly.charAt(0);
		var angleN = 0;
		while ((char) (spiderL + angleN) != flyL && (char) (spiderL - angleN) != flyL) {angleN += 1;}
		var angle = angleN * 45;
		var a = fly.charAt(1) - 48d;
		var b = spider.charAt(1) - 48d;
		return Math.sqrt(Math.pow(a, 2) + Math.pow(b, 2) - 2 * b * a * Math.cos(Math.toRadians(angle)));
	}
}
