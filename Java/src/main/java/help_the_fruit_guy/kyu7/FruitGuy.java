package help_the_fruit_guy.kyu7;

import java.util.Arrays;

public class FruitGuy {

	public static String[] removeRotten(String[] fruitBasket) {
		return (fruitBasket == null || fruitBasket.length == 0) ? new String[0] : Arrays.stream(fruitBasket)
				.map(w -> w.replace("rotten", ""))
				.map(String::toLowerCase)
				.toArray(String[]::new);
	}
}
