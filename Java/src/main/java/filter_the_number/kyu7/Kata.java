package filter_the_number.kyu7;


public class Kata {

	public static long filterString(final String value) {
		return Long.parseLong(
				value.chars()
						.filter(Character::isDigit)
						.collect(
								StringBuilder::new,
								StringBuilder::appendCodePoint,
								StringBuilder::append)
						.toString());
	}

}