import org.junit.Test;
import static org.junit.Assert.assertEquals;
import org.junit.runners.JUnit4;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.lang.Math;


public class ExampleTests {

	private static String[] show(final String[] ary) {
		System.out.println(Arrays.toString(ary));
		return ary;
	}

	@Test
	public void example() {
		assertEquals(new String[]{"a","b","c"}, show(Main.split("a.b.c")));
	}

}