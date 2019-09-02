package TheBigPronicChallenge;

import java.util.regex.Matcher;

public class Kata {

	public static void main(String[] args) {
		System.out.print("Please enter a number: ");
		long number = 2;

		long n = (long)Math.sqrt(number);
		if(n*(n+1)==number) {
			System.out.println(number+" is a pronic number");
		}else {
			System.out.println(number+" is NOT a pronic number");
		}

		System.out.println(isPronic(number));
	}


	public static boolean isPronic(long n){
		long nn = (long) Math.sqrt(n);
		return n == (nn * (nn + 1));
	}

}
