package double_every_other.ky7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class KataTest {

	@Test

	void basicTest() {
		int[] a1 = new int[]{1, 2, 3, 4};
		int[] a1s = new int[]{1, 4, 3, 8};
		int[] a2 = new int[]{1, 19, 6, 2, 12, -3};
		int[] a2s = new int[]{1, 38, 6, 4, 12, -6};
		int[] a3 = new int[]{-1000, 1653, 210, 0, 1};
		int[] a3s = new int[]{-1000, 3306, 210, 0, 1};
		assertArrayEquals(a1s, Kata.doubleEveryOther(a1), "For input [1,2,3,4]");
		assertArrayEquals(a2s, Kata.doubleEveryOther(a2), "For input [1,19,6,2,12,-3]");
		assertArrayEquals(a3s, Kata.doubleEveryOther(a3), "For input [-1000,1653,210,0,1]");
	}
}