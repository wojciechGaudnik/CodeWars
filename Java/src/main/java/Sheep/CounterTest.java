package Sheep;

import org.junit.Test;
import static org.junit.Assert.assertEquals;
import org.junit.runners.JUnit4;


public class CounterTest {
	Boolean[] array1 = {true,  true,  true,  false,
			true,  true,  true,  true ,
			true,  false, true,  false,
			true,  false, false, true ,
			true,  true,  true,  true ,
			false, false, true,  true };

	@Test
	public void testMy() {
		assertEquals("There are 17 sheeps in total", 17, new Counter().countSheeps(array1));
	}
}