package exclamation_marks_series_8_move_all_exclamation_marks_to_the_end_of_the_sentence.kyu7;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	@Test
	void basicTest() {
		assertEquals("Hi!", Kata.remove("Hi!"), String.format("For input \"%s\"", "Hi!"));
		assertEquals("Hi Hi!!", Kata.remove("Hi! Hi!"), String.format("For input \"%s\"", "Hi! Hi!"));
		assertEquals("Hi Hi Hi!!!", Kata.remove("Hi! Hi! Hi!"), String.format("For input \"%s\"", "Hi! Hi! Hi!"));
		assertEquals("Hi Hi Hi!!!", Kata.remove("Hi! !Hi Hi!"), String.format("For input \"%s\"", "Hi! !Hi Hi!"));
		assertEquals("Hi Hi Hi!!!!", Kata.remove("Hi! Hi!! Hi!"), String.format("For input \"%s\"", "Hi! Hi!! Hi!"));
	}
}