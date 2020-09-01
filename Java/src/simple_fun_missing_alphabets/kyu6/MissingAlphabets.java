package simple_fun_missing_alphabets.kyu6;

import java.util.Arrays;

class MissingAlphabets {

	static String find(final String text) {
		var alphabet = "abcdefghijklmnopqrstuvwxyz";
		long max = 0;
		for (var one : alphabet.toCharArray()) {
			if (text.chars().filter(c -> c == one).count() > max) {
				max = text.chars().filter(c -> c == one).count();
			}
		}
		alphabet = alphabet.repeat((int) max);
		for (var one : text.split("")) {
			alphabet = alphabet.replaceFirst(one, "");
		}
		var answerBuff = alphabet.toCharArray();
		Arrays.sort(answerBuff);
		return new String(answerBuff);
	}
}

