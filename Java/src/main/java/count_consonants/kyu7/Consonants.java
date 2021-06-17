package count_consonants.kyu7;

public class Consonants {
	public static int getCount(String str) {
		return (int) (str.chars().mapToObj(c -> (char) c).filter(c -> "bcdfghjklmnprstwxyzqv".contains(String.valueOf(c).toLowerCase())).count());
	}

}
