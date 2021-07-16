package shifter_words.kyu7;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ShifterTest {
	@Test
	public void on(){
		assertEquals(1, Shifter.count("ON"));
	}
	@Test
	public void osIsUpdated(){
		assertEquals(2, Shifter.count("OS IS UPDATED"));
	}
	@Test
	public void whoIsWho(){
		assertEquals(2, Shifter.count("WHO IS WHO"));
	}
	@Test
	public void js(){
		assertEquals(0, Shifter.count("JS"));
	}
	@Test
	public void iIiiIIii(){
		assertEquals(2, Shifter.count("I III I III"));
	}
	@Test
	public void empty(){
		assertEquals(0, Shifter.count(""));
	}
}