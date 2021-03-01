package interactive_dictionary.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class DictionaryTest {
	@Test
	public void Tests()
	{
		Dictionary d = new Dictionary();

		d.newEntry("Apple", "A fruit");
		assertEquals("A fruit", d.look("Apple"));

		d.newEntry("Soccer", "A sport");
		assertEquals("A sport", d.look("Soccer"));

		assertEquals("Cant find entry for Hi", d.look("Hi"));
		assertEquals("Cant find entry for Ball", d.look("Ball"));

		d.newEntry("soccer", "a sport");
		assertEquals("a sport", d.look("soccer"));
	}
}