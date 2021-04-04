package trumpness_detector.kyu6;

import java.util.regex.Pattern;

public class Trumpdetector {
	public static double detect(String trumpySpeech) {
		var patternMany = Pattern.compile("a{2,}|e{2,}|i{2,}|o{2,}|u{2,}", Pattern.CASE_INSENSITIVE);
		var matcherMany = patternMany.matcher(trumpySpeech);
		var patternAll= Pattern.compile("a{1,}|e{1,}|i{1,}|o{1,}|u{1,}", Pattern.CASE_INSENSITIVE);
		var matcherAll= patternAll.matcher(trumpySpeech);
		var length = 0.0;
		var all = 0.0;
		while (matcherMany.find()) {
			length += matcherMany.group().length() - 1;
		}
		while (matcherAll.find()) {
			all++;
		}
		return (double) Math.round((length / all) * 100) / 100;
	}
}

