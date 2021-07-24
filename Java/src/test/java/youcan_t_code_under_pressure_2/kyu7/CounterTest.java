package youcan_t_code_under_pressure_2.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

;

public class CounterTest {
	@Test
	public void Sample_Tests() {
		Counter mycounter = new Counter();

		mycounter.increment();
		mycounter.increment();
		assertEquals(2, mycounter.check());
	}
}