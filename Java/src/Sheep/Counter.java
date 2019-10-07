package Sheep;

import java.util.Objects;
import java.util.stream.Stream;

public class Counter {

	public static int countSheeps(Boolean[] arrayOfSheeps) {
		return (int) Stream.of(arrayOfSheeps).filter(Objects::nonNull).filter(e -> e.equals(true)).count();
//		return (int) Stream.of(arrayOfSheeps).filter(e -> e.getClass().isInterface()).filter(e -> e.equals(true)).mapToInt(e -> 1).count();
	}


	public static void main(String[] args) {
		Boolean[] array1 = {true,  true,  true,  false,
				true,  true,  true,  true ,
				true,  false, true,  false,
				true,  false, false, true ,
				true,  true,  true,  true ,
				false, null, true,  true };
		System.out.println(countSheeps(array1));
	}
}
