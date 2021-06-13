package fun_with_lists_reduce.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests() {
		assertEquals(0, (int) Solution.reduce(null, (a, b) -> a + b, 0));
		assertEquals(6, (int) Solution.reduce(new Node(1, new Node(2, new Node(3))), (a, b) -> a + b, 0));
		assertEquals(24, (int) Solution.reduce(new Node(1, new Node(2, new Node(3, new Node(4)))), (a, b) -> a * b, 1));
		assertEquals("abc", Solution.reduce(new Node("a", new Node("b", new Node("c"))), (a, b) -> a + b, ""));
	}
}