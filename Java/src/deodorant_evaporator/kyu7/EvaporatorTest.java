package deodorant_evaporator.kyu7;


import static org.junit.Assert.*;

import org.junit.*;

public class EvaporatorTest {
	@Test
	public void testEvaporatorOne() {
		assertEquals(22 , Evaporator.evaporator(10, 10, 10));
	}
}
