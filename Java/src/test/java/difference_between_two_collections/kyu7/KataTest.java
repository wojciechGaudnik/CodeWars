package difference_between_two_collections.kyu7;

import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void exampleTests() {
		assertEquals("should return empty for the same content",  list(),         Kata.diff(list('a', 'b'), list('a', 'b')));
		assertEquals("should return A if B is empty",             list('a', 'b'), Kata.diff(list('a', 'b'), list()));
		assertEquals("should return B if A is empty",             list('a', 'b'), Kata.diff(list(), list('a', 'b')));
		assertEquals("should return empty for the empty content", list(),         Kata.diff(list(), list()));
		assertEquals("should return the last character",          list('z'),      Kata.diff(list('a', 'b', 'z'), list('a', 'b')));
		assertEquals("should return the sorted characters",       list('d', 'e', 'j', 'z'),
				Kata.diff(list('a', 'b', 'z', 'd', 'e', 'd'), list('a', 'b', 'j', 'j')));
	}

	public List<Character> list(char... elements) {
		ArrayList<Character> list = new ArrayList<>();
		for (char s : elements) {
			list.add(s);
		}
		return list;
	}
}