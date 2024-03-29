package rock_off.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
public class SolutionTest {
	@Test
	public void BasicTests()
	{
		assertEquals("0, 0: that looks like a \"draw\"! Rock on!", Solution.solveRockOff(new int[]{47, 7, 2}, new int[]{47, 7, 2}));
		assertEquals("3, 0: Alice made \"Kurt\" proud!", Solution.solveRockOff(new int[]{47, 67, 22}, new int[]{26, 47, 12}));
		assertEquals("1, 2: Bob made \"Jeff\" proud!", Solution.solveRockOff(new int[]{25, 50, 22}, new int[]{34, 49, 50}));
	}
}