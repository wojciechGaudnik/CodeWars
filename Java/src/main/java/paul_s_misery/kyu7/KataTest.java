package paul_s_misery.kyu7;

import org.junit.jupiter.api.Test;
		import static org.junit.jupiter.api.Assertions.assertEquals;
		import java.util.Arrays;
		import java.util.stream.Collectors;

class KataTest {

	@Test
	void basicTest(){
		String[] a1 = new String[]{"life", "eating", "life"};
		String a1s = Arrays.stream(a1).collect(Collectors.joining(", "));
		String[] a2 = new String[]{"life", "Petes kata", "Petes kata", "Petes kata", "eating"};
		String[] a3 = new String[]{"Petes kata", "Petes kata", "eating", "Petes kata", "Petes kata", "eating"};
		String a2s = Arrays.stream(a3).collect(Collectors.joining(", "));
		String a3s = Arrays.stream(a3).collect(Collectors.joining(", "));
		String[] a4 = new String[]{"Petes kata", "Petes kata","Petes kata","Petes kata","Petes kata","Petes kata","Petes kata","Petes kata","Petes kata","kata", "eating", "eating", "eating", "eating"};
		String a4s = Arrays.stream(a4).collect(Collectors.joining(", "));

		assertEquals("Super happy!", Kata.paul(a1), "For input \"" + a1s + "\"");
		assertEquals("Super happy!", Kata.paul(a2), "For input \"" + a2s + "\"");
		assertEquals("Happy!", Kata.paul(a3), "For input \"" + a3s + "\"");
		assertEquals("Sad!", Kata.paul(a4), "For input \"" + a4s + "\"");

	}
}
