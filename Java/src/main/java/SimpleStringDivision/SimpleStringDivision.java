package SimpleStringDivision;

public class SimpleStringDivision {

	public static int solve(String s, int k) {
		String[] pairs = s.split(" ");
		int count = 0;
		for (int i = 0; i < pairs.length; i++) {
			for (int j = i + 1; j < pairs.length; j++) {
				if (Integer.parseInt(pairs[i] + pairs[j]) % k == 0) {
					count++;
				}
				if (Integer.parseInt(pairs[j] + pairs[i]) % k == 0) {
					count++;
				}

			}
		}
		return count;
	}
}
