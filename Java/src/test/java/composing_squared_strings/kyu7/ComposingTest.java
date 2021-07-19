package composing_squared_strings.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class ComposingTest {

	private static void testing(String actual, String expected) {
		assertEquals(expected, actual);
	}
	private static int randInt(int min, int max) {
		return (int)(min + Math.random() * ((max - min) + 1));
	}
	@Test
	public void test() {
		System.out.println("Fixed Tests compose");
		testing(Composing.compose("byGt\nhTts\nRTFF\nCnnI", "jIRl\nViBu\nrWOb\nNkTB"),
				"bNkTB\nhTrWO\nRTFVi\nCnnIj");
		testing(Composing.compose("HXxA\nTGBf\nIPhg\nuUMD", "Hcbj\nqteH\nGbMJ\ngYPW"),
				"HgYPW\nTGGbM\nIPhqt\nuUMDH");
		testing(Composing.compose("tSrJ\nOONy\nsqPF\nxMkB", "hLqw\nEZuh\nmYFl\nzlYf"),
				"tzlYf\nOOmYF\nsqPEZ\nxMkBh");
	}
}