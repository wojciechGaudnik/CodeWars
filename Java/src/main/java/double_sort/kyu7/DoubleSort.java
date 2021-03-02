package double_sort.kyu7;

import java.util.Arrays;
import java.util.stream.Stream;

public class DoubleSort {
	public static Object[] dbSort(Object[] a){
		var numbers = Arrays.stream(a).filter(e -> e.getClass().equals(Integer.class)).sorted();
		var strings = Arrays.stream(a).filter(e -> e.getClass().equals(String.class)).sorted();
		return Stream.concat(numbers, strings).toArray();
	}
}
