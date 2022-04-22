package aerial_firefighting.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {

	@Test
	public void basicTests() {
		assertEquals(3, Solution.waterbombs("xxxxYxYx", 4));
		assertEquals(2, Solution.waterbombs("xxYxx", 3));
	}

}
