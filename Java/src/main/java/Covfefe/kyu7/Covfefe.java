package Covfefe.kyu7;

public class Covfefe {

	public static String covfefe(String tweet) {
		return (!tweet.contains("coverage")) ? tweet + " covfefe" : tweet.replaceAll("coverage", "covfefe");
	}
}
