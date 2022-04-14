package longest_common_subsequence.kyu5;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

import org.junit.runners.JUnit4;

public class SolutionTest {
	@Test
	public void exampleTests() {
		assertEquals("", Solution.lcs("a", "b"));
		assertEquals("abc", Solution.lcs("abcdef", "abc"));
		assertEquals("nottest", Solution.lcs("anothertest", "notatest"));
	}
}