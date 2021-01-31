package convert_a_linked_list_to_a_string.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void sampleTests() {
		assertEquals("1 -> 2 -> 3 -> null", Kata.stringify(new Node(1, new Node(2, new Node(3)))));
		assertEquals("0 -> 1 -> 4 -> 9 -> 16 -> null", Kata.stringify(new Node(0, new Node(1, new Node(4, new Node(9, new Node(16)))))));
		assertEquals("null", Kata.stringify(null));
	}
}