package consecutive_ducks.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class KataTest {

	@Test
	public void checkSmallValues() {

	}
	@Test
	public void checkMediumValues() {
		Kata.consecutiveDucks(32768, false);
		Kata.consecutiveDucks(512, false);
		Kata.consecutiveDucks(16, false);
		Kata.consecutiveDucks(8, false);
	}
	@Test
	public void checkLargeValues() {
		Kata.consecutiveDucks(69, true);
		Kata.consecutiveDucks(57, true);
		Kata.consecutiveDucks(6, true);
		Kata.consecutiveDucks(13, true);
		Kata.consecutiveDucks(91, true);
		Kata.consecutiveDucks(522, true);
		Kata.consecutiveDucks(974, true);
		Kata.consecutiveDucks(755, true);
		Kata.consecutiveDucks(739, true);
		Kata.consecutiveDucks(1006, true);
		Kata.consecutiveDucks(838, true);
		Kata.consecutiveDucks(382131, true);
		Kata.consecutiveDucks(118070, true);
		Kata.consecutiveDucks(17209, true);
		Kata.consecutiveDucks(161997, true);
		Kata.consecutiveDucks(400779, true);
		Kata.consecutiveDucks(198331, true);
	}

	@Test
	public void myTrue(){
		assertTrue(Kata.consecutiveDucks(69));
		assertTrue(Kata.consecutiveDucks(57));
		assertTrue(Kata.consecutiveDucks(6));
		assertTrue(Kata.consecutiveDucks(13));
		assertTrue(Kata.consecutiveDucks(91));
		assertTrue(Kata.consecutiveDucks(522));
		assertTrue(Kata.consecutiveDucks(974));
		assertTrue(Kata.consecutiveDucks(755));
		assertTrue(Kata.consecutiveDucks(739));
		assertTrue(Kata.consecutiveDucks(1006));
		assertTrue(Kata.consecutiveDucks(838));
		assertTrue(Kata.consecutiveDucks(382131));
		assertTrue(Kata.consecutiveDucks(118070));
		assertTrue(Kata.consecutiveDucks(17209));
		assertTrue(Kata.consecutiveDucks(161997));
		assertTrue(Kata.consecutiveDucks(400779));
		assertTrue(Kata.consecutiveDucks(198331));

		assertTrue(Kata.consecutiveDucks(123369113));
		assertTrue(Kata.consecutiveDucks(131962822));
		assertTrue(Kata.consecutiveDucks(1656742680));
		assertTrue(Kata.consecutiveDucks(190980787));
		assertTrue(Kata.consecutiveDucks(1021954669));
		assertTrue(Kata.consecutiveDucks(401058709));
		assertTrue(Kata.consecutiveDucks(636244363));
		assertTrue(Kata.consecutiveDucks(1650359758));
		assertTrue(Kata.consecutiveDucks(1853154031));
		assertTrue(Kata.consecutiveDucks(458505357));
		assertTrue(Kata.consecutiveDucks(143307166));
		assertTrue(Kata.consecutiveDucks(339482207));
		assertTrue(Kata.consecutiveDucks(103796266));
		assertTrue(Kata.consecutiveDucks(1658946068));
		assertTrue(Kata.consecutiveDucks(1424457191));
		assertTrue(Kata.consecutiveDucks(383809358));
		assertTrue(Kata.consecutiveDucks(817918378));
		assertTrue(Kata.consecutiveDucks(1817601005));
		assertTrue(Kata.consecutiveDucks(447851081));
		assertTrue(Kata.consecutiveDucks(1884009789));
		assertTrue(Kata.consecutiveDucks(1868584833));
		assertTrue(Kata.consecutiveDucks(251164406));
		assertTrue(Kata.consecutiveDucks(576554657));
		assertTrue(Kata.consecutiveDucks(1438483182));
	}

	@Test
	public void myFalse() {
		assertFalse(Kata.consecutiveDucks(32768));
		assertFalse(Kata.consecutiveDucks(512));
		assertFalse(Kata.consecutiveDucks(16));
		assertFalse(Kata.consecutiveDucks(8));
	}
}