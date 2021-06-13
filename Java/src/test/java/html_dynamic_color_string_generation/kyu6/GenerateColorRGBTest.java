package html_dynamic_color_string_generation.kyu6;

import org.junit.Test;

import java.util.Random;

import static org.junit.Assert.assertEquals;

public class GenerateColorRGBTest {
	@Test
	public void symbolTest() throws Exception {
		assertEquals("#", GenerateColorRGB.generateColor( new Random() ).substring(0,1) );
	}
}