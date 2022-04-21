package valid_spacing.kyu7;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertTrue;
import static org.junit.jupiter.api.Assertions.assertFalse;

// TODO: Replace examples and use TDD by writing your own tests

class KataTest {
	@Test
	void fixedTests() {
		assertTrue (Kata.validSpacing("Hello world"), "'Hello world'");
		assertFalse(Kata.validSpacing(" Hello world"), "' Hello world'");
		assertFalse(Kata.validSpacing("Hello  world "), "'Hello  world '");
		assertTrue (Kata.validSpacing("Hello"), "'Hello'");
		assertTrue (Kata.validSpacing("Helloworld"), "'Helloworld'");
	}
}
