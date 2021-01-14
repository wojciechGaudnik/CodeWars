package Plural;

public class Plural{

	public static boolean isEven(double n) {
		return (n) % 2 == 0;
	}

	public static String replaceDots(final String str) {
		return str.replaceAll("\\.", "-");
	}

	public static boolean isPlural(float f){
		return f != 1;
	}
}