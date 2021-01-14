package divisible_ints.kyu6;

import static org.junit.Assert.*;
import org.junit.Test;

public class KataTest {

	private static void testing(int actual, int expected) {
		assertEquals(expected, actual);
	}

	@Test
	public void test() {
		System.out.println("Fixed Tests getCount");
		testing(Kata.getCount(123),2);
		testing(Kata.getCount(1230),5);
		testing(Kata.getCount(1),0);
		testing(Kata.getCount(1111111111),25);
	}

}

