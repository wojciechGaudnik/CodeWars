package ultimate_array_reverser.kyu7;

import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class ArrayReverserTest {
	@Test public void FixedTest1()
	{
		assertEquals(new String[]{"!", "eilt", "onn", "acIdn", "ast", "t", "ubgibe", "kilI"},
				ArrayReverser.reverse(new String[]{"I", "like", "big", "butts", "and", "I", "cannot", "lie!"}));
	}
	@Test
	public void FixedTest2()
	{
		assertEquals(new String[]
						{"How", "many", "shrimp", "do", "you", "have", "to", "eat",
								"before", "your", "skin", "starts", "to", "turn", "pink?"},
				ArrayReverser.reverse(new String[]{"?kn", "ipnr", "utotst", "ra", "tsn", "iksr", "uo", "yer", "ofebta", "eote", "vahu", "oyodpm", "ir", "hsyn", "amwoH"}));
	}
}