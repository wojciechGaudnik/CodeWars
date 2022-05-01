package previous_multiple_of_three.kyu7;

public class Kata {

	public static Integer prevMultOfThree(int n){
		if (n % 3 == 0) {
			return n;
		}
		var nString = String.valueOf(n);
		do {
			nString = nString.substring(0, nString.length() - 1);
			if (nString.length() > 0 && Integer.parseInt(nString) % 3 == 0) {
				return Integer.parseInt(nString);
			}
		} while (nString.length() > 0);
		return null;
	}

}