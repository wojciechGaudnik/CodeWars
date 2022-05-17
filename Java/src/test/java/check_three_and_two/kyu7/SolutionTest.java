package check_three_and_two.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void testSomething() {
		assertEquals(true, new Solution().checkThreeAndTwo(new char[]{'a', 'a', 'b', 'b', 'b'}));
		assertEquals(false, new Solution().checkThreeAndTwo(new char[]{'a', 'c', 'a', 'c', 'b'}));
		assertEquals(false, new Solution().checkThreeAndTwo(new char[]{'a', 'a', 'a', 'a', 'a'}));
	}
}