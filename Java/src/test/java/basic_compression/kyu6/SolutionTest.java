package basic_compression.kyu6;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class SolutionTest {
	@Test
	public void test() {
		assertEquals("[[14,\"a\"],[1,\"b\"],[41,\"a\"],[1,\"c\"]]", Solution.compress("aaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaac"));
		assertEquals("abcde", Solution.compress("abcde"));
		assertEquals("aaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaac", Solution.decompress("[[14,\"a\"],[1,\"b\"],[41,\"a\"],[1,\"c\"]]"));
		assertEquals("abcde", Solution.decompress("abcde"));
	}
}