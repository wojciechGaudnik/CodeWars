package remove_duplicate_words.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("alpha beta gamma delta", Solution.removeDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"));
		assertEquals("my cat is fat", Solution.removeDuplicateWords("my cat is my cat fat"));
	}
}