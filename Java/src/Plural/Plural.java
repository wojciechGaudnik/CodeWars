package Plural;

public class Plural{

	public static void main(String[] args) {
		System.out.println(isEven(-5));
		//		System.out.println(replaceDots("one.two.three"));

//		System.out.println(isPlural(100f));

	}

	public static boolean isEven(double n) {
//		Double.
		return (n) % 2 == 0;
		// Your awesome code here!
	}

	public static String replaceDots(final String str) {
		return str.replaceAll("\\.", "-");
	}

	public static boolean isPlural(float f){
		return f != 1;
	}
}