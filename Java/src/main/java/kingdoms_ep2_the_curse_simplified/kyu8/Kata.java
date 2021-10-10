package kingdoms_ep2_the_curse_simplified.kyu8;

import java.util.regex.Pattern;

class Kata {

	public static void main(String[] args) {
		System.out.println(translate("***lo w***d!", new String[]{"hello", "world"}));
	}
	static String translate(String speech, String[] vocabulary) {
		var kingsWords = Pattern.compile("[a-z*]*").matcher(speech);
		while (kingsWords.find()) {
			for (var one : vocabulary) {
				if (testWords(kingsWords.group(), one)) {
					speech = speech.replaceFirst(kingsWords.group().replace("*", "\\*"), one);
				}
			}
		}
		return speech;
	}

	private static boolean testWords(String kindsWord, String vocabularyWord) {
		if (kindsWord.length() != vocabularyWord.length()) {
			return false;
		}
		for (var i = 0; i < kindsWord.length(); i++) {
			if (kindsWord.charAt(i) != '*' && kindsWord.charAt(i) != vocabularyWord.charAt(i)) {
				return false;
			}
		}
		return true;
	}
}
