package find_the_smallest.kyu6;


import static org.junit.Assert.*;
import java.util.Arrays;
import org.junit.Test;

public class ToSmallestTest {

	private static void testing(long n, String res) {
		assertEquals(res,
				Arrays.toString(ToSmallest.smallest(n)));
	}
	@Test
	public void test() {
		System.out.println("Basic Tests smallest");
		testing(261235, "[126235, 2, 0]");
		testing(209917, "[29917, 0, 1]");
		testing(285365, "[238565, 3, 1]");
		testing(269045, "[26945, 3, 0]");
		testing(296837, "[239687, 4, 1]");
		testing(187863002809L, "[18786300289, 10, 0]");
		testing(914314119673934592L, "[143141196739345929, 0, 17]");
	}
}