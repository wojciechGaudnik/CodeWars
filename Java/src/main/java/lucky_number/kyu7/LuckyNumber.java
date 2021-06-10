package lucky_number.kyu7;

public class LuckyNumber {
	public static boolean isLucky(long n) {
		return String.valueOf(n).chars().mapToObj(Character::getNumericValue).mapToInt(Integer::intValue).sum() % 9 == 0;
	}

}
