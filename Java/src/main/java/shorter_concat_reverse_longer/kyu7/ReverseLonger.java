package shorter_concat_reverse_longer.kyu7;

public class ReverseLonger {

	public static String shorterReverseLonger(String a, String b) {
		var longer = new StringBuffer((a.length() >= b.length()) ? a : b).reverse().toString();
		var shorter = (a.length() >= b.length()) ? b : a;
		return shorter + longer + shorter;
	}
}
