package trumpness_detector.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class TrumpdetectorTest {
	@Test
	public void sampleTests() {
		assertEquals(0, Trumpdetector.detect("I will build a huge wall"),0.001);
		assertEquals(4, Trumpdetector.detect("HUUUUUGEEEE WAAAAAALL"),0.001);
		assertEquals(2.5, Trumpdetector.detect("MEXICAAAAAAAANS GOOOO HOOOMEEEE"),0.001);
		assertEquals(1.89, Trumpdetector.detect("America NUUUUUKEEEE Oooobaaaamaaaaa"),0.001);
		assertEquals(1.56, Trumpdetector.detect("listen migrants: IIII KIIIDD YOOOUUU NOOOOOOTTT"),0.001);
	}
}