package ExelColumn;


public class GetExcelColumnTitle {


	public static String getColumnTitle(int num) {
		if (num < 1) {
			throw new IllegalArgumentException();
		}
		StringBuilder out = new StringBuilder();
		int reminder = 0;
		while (num > 0) {
			reminder = (num - 1) % 26;
			out.insert(0, Character.toString(65 + reminder));
			num = (num - reminder) / 26;
		}
		return out.toString();
	}
}
