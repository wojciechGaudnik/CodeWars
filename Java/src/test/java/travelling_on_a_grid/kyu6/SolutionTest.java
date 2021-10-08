package travelling_on_a_grid.kyu6;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void testSomeValues1() {
		assertEquals(6  ,Solution.travelChessboard("(1 1)(3 3)"));
	}
	@Test
	public void testSomeValues2() {
		assertEquals(21 ,Solution.travelChessboard("(2 3)(4 8)"));
	}
	@Test
	public void testSomeValues3() {
		assertEquals(1  ,Solution.travelChessboard("(1 8)(4 8)"));
	}
	@Test
	public void testSomeValues7() {
		assertEquals(330,Solution.travelChessboard("(3 1)(7 8)"));
	}
}