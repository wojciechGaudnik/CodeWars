package bishop_movement_checker.kyu6;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;
public class SolutionTest {
	@Test
	public void sampleTests() {
		assertEquals(true,Solution.bishop("a1","b4",2));
		assertEquals(false,Solution.bishop("a1","b5",5));
		assertEquals(true,Solution.bishop("f1","f1",0));
		assertEquals(false,Solution.bishop("e6","a1",2));
	}
}