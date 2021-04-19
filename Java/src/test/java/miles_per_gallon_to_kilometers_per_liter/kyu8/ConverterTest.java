package miles_per_gallon_to_kilometers_per_liter.kyu8;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ConverterTest {
	@Test
	public void test1() {
		assertEquals(3.54f, Converter.mpgToKPM(10), 0.001f);
	}

	@Test
	public void test2() {
		assertEquals(7.08f, Converter.mpgToKPM(20), 0.001f);
	}

	@Test
	public void test3() {
		assertEquals(10.62f, Converter.mpgToKPM(30), 0.001f);
	}
}