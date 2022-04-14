package name_array_capping.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class KataTest {


	@Test
	public void downcase() {
		String[] strings = new String[]{"jo", "nelson", "jurie"};
		assertEquals(new String[]{"Jo", "Nelson", "Jurie"}, Kata.capMe(strings));
	}

}