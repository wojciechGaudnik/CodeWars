package whats_my_golf_score.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {
	@Test
	public void exampleTest() {
		assertEquals(-1, Kata.golfScoreCalculator("443454444344544443", "353445334534445344"));
	}
}