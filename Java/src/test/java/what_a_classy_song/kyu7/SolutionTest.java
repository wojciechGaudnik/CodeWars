package what_a_classy_song.kyu7;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;

import static org.junit.Assert.assertEquals;

public class SolutionTest {

	Song song = new Song("Mount Moose", "The Snazzy Moose");
	@Test
	public void TestForTitleAndArtist() {
		assertEquals("Wrong title!", "Mount Moose", song.getTitle());
		assertEquals("Wrong artist!", "The Snazzy Moose", song.getArtist());
	}

	@Test
	public void TestForDataEncapsulation() {
		assertEquals("Make sure that your attributes are private!", 0, song.getClass().getFields().length);
	}

	@Test
	public void TestHowManyMethod() {
		assertEquals(5, song.howMany(new ArrayList<String>(Arrays.asList("John", "Fred", "Bob", "Carl", "RyAn"))));
		assertEquals(2, song.howMany(new ArrayList<String>(Arrays.asList("JoHn", "Luke", "AmAndA"))));
		assertEquals(2, song.howMany(new ArrayList<String>(Arrays.asList("Amanda", "CalEb", "CarL", "Furgus"))));
		assertEquals(1, song.howMany(new ArrayList<String>(Arrays.asList("JOHN", "FRED", "BOB", "CARL", "RYAN", "KATE"))));
		assertEquals(1, song.howMany(new ArrayList<String>(Arrays.asList("Jack", "jacK"))));
	}
}