package first_variation_on_caesar_cipher.kyu5;

import java.util.LinkedList;
import java.util.List;

public class CaesarCipher {

	public static List<String>  movingShift(String s, int shift) {
		var listAnswer = new LinkedList<String>();
		var answer = new StringBuilder();
		for (var i = 0; i < s.length(); i++) {
			var letter = s.charAt(i);
			if (Character.isUpperCase(letter)) {
				answer.append((char) ('A' + (((letter - 'A') + shift + i) % 26)));
			} else if (Character.isLowerCase(letter)) {
				answer.append((char) ('a' + (((letter - 'a') + shift + i) % 26)));
			} else {
				answer.append(letter);
			}
		}

		if (answer.length() % 5 == 0) {
			var equalsLenght = answer.length() / 5;
			for (var i = 0; i <= answer.length() - equalsLenght; i += equalsLenght) {
				listAnswer.add(answer.substring(i, i + equalsLenght));
			}
		} else {
			var equalsLenght = (answer.length() / 5) + 1;
			for (var i = 0;; i += equalsLenght) {
				if (i + equalsLenght >= answer.length()) {
					listAnswer.add(answer.substring(i));
					break;
				}
				listAnswer.add(answer.substring(i, i + equalsLenght));
			}
		}
		while (listAnswer.size() != 5) listAnswer.add("");
		return listAnswer;
	}

	public static String  demovingShift(List<String> ss, int shift) {
		var s = String.join("", ss);
		shift = 26 - (shift % 26);
		var answer = new StringBuilder();
		for (var i = 0; i < s.length(); i++) {
			var letter = s.charAt(i);
			if (Character.isUpperCase(letter)) {
				answer.append((char) ('A' + (((letter - 'A') + shift - (i % 26)) % 26)));
			} else if (Character.isLowerCase(letter)) {
				answer.append((char) ('a' + (((letter - 'a') + shift - (i % 26)) % 26)));
			} else {
				answer.append(letter);
			}
		}
		return answer.toString();
	}
}
   
