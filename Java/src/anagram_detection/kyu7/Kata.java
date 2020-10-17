package anagram_detection.kyu7;

import java.util.Arrays;

public class Kata {

	public static boolean isAnagram(String test, String original) {
		var testString = getSortedString(test.toLowerCase());
		var originalString = getSortedString(original.toLowerCase());
		return testString.equals(originalString);
	}

	private static String getSortedString(String test) {
		var testArr = test.toCharArray();
		Arrays.sort(testArr);
		return String.valueOf(testArr);
	}
}
   
