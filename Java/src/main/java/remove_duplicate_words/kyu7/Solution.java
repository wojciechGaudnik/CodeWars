package remove_duplicate_words.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class Solution {
	public static void main(String[] args) {
		System.out.println(removeDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"));
	}

	public static String removeDuplicateWords(String s) {
		return Arrays.stream(s.split(" ")).distinct().collect(Collectors.joining(" "));
	}
}
   
