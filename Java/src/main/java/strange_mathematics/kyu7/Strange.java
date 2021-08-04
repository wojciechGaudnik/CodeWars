package strange_mathematics.kyu7;

import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Strange {
	public static int mathematics(int n, int k){
		return IntStream.range(0, n + 1).mapToObj(String::valueOf).sorted().collect(Collectors.toList()).indexOf(String.valueOf(k));
	}
}
