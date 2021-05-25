package word_to_initial_number.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ConverterTest {

	@Test
	public void convert_test0() {
		int R = 10234567;
		String s = "CodeWars";

		assertEquals(R, Converter.convert(s));
	}

	@Test
	public void convert_test1() {
		int R = 1020;
		String s = "KATA";

		assertEquals(R, Converter.convert(s));
	}
}