package calculate_mean_and_concatenate_string.kyu7;

import java.util.stream.Collectors;

public class Kata {

	public static Object[] mean(char[] lst){
		var mean = new String(lst).chars().filter(Character::isDigit).mapToObj(Character::getNumericValue).mapToInt(e -> e).average().orElse(0.0);
		var string = new String(lst).chars().filter(Character::isAlphabetic).mapToObj(Character::toString).collect(Collectors.joining());
		return new Object[]{mean, string};
	}
}
