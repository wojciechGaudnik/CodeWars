package word_segmentation_max_match.kyu6;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void goodLuck() {
		List<String> expected = new ArrayList<String>(Arrays.asList("good","luck"));
		assertEquals(expected, Kata.maxMatch("goodluck"));
	}
	@Test
	public void invalidWord() {
		List<String> expected = new ArrayList<String>(Arrays.asList("e","w","in","g","s","a"));
		assertEquals(expected, Kata.maxMatch("ewingsa"));
		// "invalid" just means the word, "ewingsa", is not in the Set VALID_WORDS
	}
}