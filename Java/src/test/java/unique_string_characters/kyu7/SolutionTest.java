package unique_string_characters.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("ybzc",Solution.solve("xyab","xzca"));
		assertEquals("ybbzc",Solution.solve("xyabb","xzca"));
		assertEquals("abcdxyz",Solution.solve("abcd","xyz"));
		assertEquals("zca",Solution.solve("xxx","xzca"));
	}

}