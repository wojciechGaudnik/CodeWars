package series_of_integers_from_0_to_n.kyu7;

import org.junit.jupiter.api.Test;

		import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class KataTest {

	@Test
	void basicTest(){
		assertArrayEquals(new int[]{0,1,2,3}, Kata.generateIntegers(3), String.format("For input \"%s\"", "3"));
		assertArrayEquals(new int[]{0}, Kata.generateIntegers(0), String.format("For input \"%s\"", "0"));
	}
}