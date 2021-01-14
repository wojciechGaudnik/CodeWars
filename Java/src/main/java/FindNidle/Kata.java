package FindNidle;

import java.util.OptionalInt;
import java.util.stream.IntStream;

public class Kata {


	public static String findNeedle(Object[] haystack) {
		OptionalInt index = IntStream.range(0, haystack.length).filter(i -> haystack[i] != null && haystack[i].equals("needle")).findFirst();
		return (index.isPresent()) ? "found the needle at position " + index.getAsInt() : "";
	}
}
