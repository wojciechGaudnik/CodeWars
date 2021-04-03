package simple_time_difference.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("23:59",Solution.solve(new String[] {"14:51"}));
		assertEquals("09:10",Solution.solve(new String[] {"21:14", "15:34", "14:51", "06:25", "15:30"}));
		assertEquals("11:40",Solution.solve(new String[] {"23:00","04:22","18:05","06:24"}));
	}
}