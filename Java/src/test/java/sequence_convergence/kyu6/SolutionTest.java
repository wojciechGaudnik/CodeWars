package sequence_convergence.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals(5,Solution.convergence(3));
		assertEquals(6,Solution.convergence(5));
		assertEquals(5,Solution.convergence(10));
		assertEquals(2,Solution.convergence(15));
		assertEquals(29,Solution.convergence(500));
		assertEquals(283,Solution.convergence(5000));
	}
}