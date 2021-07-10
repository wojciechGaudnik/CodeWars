package excel_sheet_column_numbers.kyu7;

import java.util.stream.IntStream;

public class TitleToNumber {
	public static long titleToNumber1(String title) {
		var answer = 0L;
		for (var one : title.toCharArray()) {
			answer = answer * 26 + (one - 64);
		}
		return answer;
	}

	public static long titleToNumber(String title) {
		return IntStream.range(0, title.length()).mapToObj(i -> title.charAt(i) - 64L).reduce(0L, (s, n) -> s * 26 + n);
	}

}
