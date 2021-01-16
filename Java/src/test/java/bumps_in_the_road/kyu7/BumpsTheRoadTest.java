package bumps_in_the_road.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class BumpsTheRoadTest {
	@Test
	public void basicTest() {
		assertEquals(BumpsTheRoad.bumps("n"), "Woohoo!");
		assertEquals(BumpsTheRoad.bumps("_nnnnnnn_n__n______nn__nn_nnn"), "Car Dead");
		assertEquals(BumpsTheRoad.bumps("______n___n_"), "Woohoo!");
		assertEquals(BumpsTheRoad.bumps("nnnnnnnnnnnnnnnnnnnnn"), "Car Dead");
	}
}