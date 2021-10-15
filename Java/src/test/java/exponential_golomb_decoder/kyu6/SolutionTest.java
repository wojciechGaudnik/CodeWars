package exponential_golomb_decoder.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;
public class SolutionTest {
	@Test
	public void basicTests() {
		assertArrayEquals(new int[]{1, 2, 3}, Solution.decoder("01001100100"));
		assertArrayEquals(new int[]{40, 30, 10, 5}, Solution.decoder("00000101001000011111000101100110"));
		assertArrayEquals(new int[]{0, 0, 0, 800, 800, 800, 0, 0, 0}, Solution.decoder("111000000000110010000100000000011001000010000000001100100001111"));
		assertArrayEquals(new int[]{63}, Solution.decoder("0000001000000"));
		assertArrayEquals(new int[]{0}, Solution.decoder("1"));
		assertArrayEquals(new int[]{1, 0, 1, 0, 1, 0, 0, 1, 1}, Solution.decoder("0101010101011010010"));
		assertArrayEquals(new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 127}, Solution.decoder("111111111111000000010000000"));
	}
}