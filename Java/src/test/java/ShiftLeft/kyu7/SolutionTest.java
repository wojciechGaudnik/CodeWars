package ShiftLeft.kyu7;

import org.junit.Test;
import org.junit.jupiter.api.DisplayName;

import static org.junit.Assert.assertEquals;
import static org.junit.jupiter.api.Assertions.assertAll;

public class SolutionTest {
	@Test
	@DisplayName("Test cases")
	public void shouldBeEqual() {
		assertAll(
				() -> assertEquals(2, Solution.shiftLeft("test", "west")),
				() -> assertEquals(7, Solution.shiftLeft("test", "yes")),
				() -> assertEquals(1, Solution.shiftLeft("b", "ab")),
				() -> assertEquals(0, Solution.shiftLeft("", ""))
		);
	}
}