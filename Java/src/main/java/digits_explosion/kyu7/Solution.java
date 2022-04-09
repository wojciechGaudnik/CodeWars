package digits_explosion.kyu7;

import lombok.AccessLevel;
import lombok.NoArgsConstructor;

import static java.util.stream.Collectors.joining;

@NoArgsConstructor(access = AccessLevel.PRIVATE)
class Solution {
	public static String explode(String digits) {
		return digits.chars()
				.mapToObj(c -> (char) c)
				.mapToInt(Character::getNumericValue)
				.mapToObj(i -> String.valueOf(i).repeat(i))
				.collect(joining());
	}

}