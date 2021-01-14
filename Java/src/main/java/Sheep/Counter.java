package Sheep;

import java.util.Objects;
import java.util.stream.Stream;

public class Counter {

	public static int countSheeps(Boolean[] arrayOfSheeps) {
		return (int) Stream.of(arrayOfSheeps).filter(Objects::nonNull).filter(e -> e.equals(true)).count();
	}
}
