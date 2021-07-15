package Ch4113ng3.kyu7;

public class Nerd {
	public static String nerdify(String txt){
		return txt.replaceAll("(?i)a", "4").replaceAll("(?i)e", "3").replaceAll("l", "1");
	}
}
