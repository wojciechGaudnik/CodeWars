package compare_strings_by_sum_of_chars.kyu7;

public class Kata {

	public static boolean compare(String s1, String s2) {
		if (s1 == null || !s1.chars().mapToObj(c -> (char) c).allMatch(Character::isLetter)) {
			s1 = "";
		}
		if (s2 == null || !s2.chars().mapToObj(c -> (char) c).allMatch(Character::isLetter)) {
			s2 = "";
		}
		s1 = s1.toUpperCase();
		s2 = s2.toUpperCase();
		var s1Sum = s1.chars().sum();
		var s2Sum = s2.chars().sum();
		System.out.println(s1Sum);
		System.out.println(s2Sum);
		return s1Sum == s2Sum;
	}
}
