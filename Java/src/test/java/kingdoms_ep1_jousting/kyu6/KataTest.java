package kingdoms_ep1_jousting.kyu6;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertArrayEquals;

class Tests {
	@Test
	void sampleJousting() {
		assertArrayEquals(new String[]{
				" $->   ",
				"   <-P "
		}, Kata.joust(new String[]{
				"$->    ",
				"    <-P"
		}, 1, 1));
		assertArrayEquals(new String[]{
				"  $->   ",
				"   <-P  "
		}, Kata.joust(new String[]{
				"$->     ",
				"     <-P"
		}, 1, 1));
		assertArrayEquals(new String[]{
				"      $->        ",
				"        <-P      "
		}, Kata.joust(new String[]{
				"$->              ",
				"              <-P"
		}, 1, 1));
	}

	@Test
	void differentVelocity() {
		assertArrayEquals(new String[]{
				"   $-> ",
				" <-P   "
		}, Kata.joust(new String[]{
				"$->    ",
				"    <-P"
		}, 3, 3));
		assertArrayEquals(new String[]{
				"$->     ",
				" <-P    "
		}, Kata.joust(new String[]{
				"$->     ",
				"     <-P"
		}, 0, 2));
		assertArrayEquals(new String[]{
				"      $->        ",
				"     <-P         "
		}, Kata.joust(new String[]{
				"$->              ",
				"              <-P"
		}, 2, 3));
	}

	@Test
	void immediateBattle() {
		assertArrayEquals(new String[]{
				"$->  ",
				"  <-P"
		}, Kata.joust(new String[]{
				"$->  ",
				"  <-P"
		}, 3, 3));
		assertArrayEquals(new String[]{
				"$->",
				"<-P"
		}, Kata.joust(new String[]{
				"$->",
				"<-P"
		}, 3, 3));
		assertArrayEquals(new String[]{
				"$-> ",
				" <-P"
		}, Kata.joust(new String[]{
				"$-> ",
				" <-P"
		}, 0, 0));
	}

	@Test
	void knightsRefusedToFight() {
		assertArrayEquals(new String[]{
				"$->    ",
				"    <-P"
		}, Kata.joust(new String[]{
				"$->    ",
				"    <-P"
		}, 0, 0));
	}
}