package grill_it.kyu6;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class GrillIt {

	public static String grille(String message, int code) {
		if (message.equals("")) return "";
		var messageReversed = new StringBuilder(message).reverse();
		var codeSheetReversed = new StringBuilder(Integer.toBinaryString(code)).reverse();
		return new StringBuilder(IntStream.range(0, Math.min(codeSheetReversed.length(), messageReversed.length()))
				.filter(i -> codeSheetReversed.charAt(i) == '1')
				.mapToObj(i -> String.valueOf(messageReversed.charAt(i)))
				.collect(Collectors.joining())).reverse().toString();
	}
}
