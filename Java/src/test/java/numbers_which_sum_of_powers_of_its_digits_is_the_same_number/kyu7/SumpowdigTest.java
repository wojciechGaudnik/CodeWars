package numbers_which_sum_of_powers_of_its_digits_is_the_same_number.kyu7;

import org.junit.Test;

import java.util.Arrays;

import static org.junit.Assert.assertEquals;

public class SumpowdigTest {
	@Test
	public void test() {
		System.out.println("Fixed Tests");
		assertEquals("[]", Arrays.toString(Sumpowdig.eqSumPowDig(100, 2)));
		assertEquals("[153]", Arrays.toString(Sumpowdig.eqSumPowDig(200, 3)));
		assertEquals("[153, 370]", Arrays.toString(Sumpowdig.eqSumPowDig(370, 3)));
		assertEquals("[153, 370, 371]", Arrays.toString(Sumpowdig.eqSumPowDig(400, 3)));
		assertEquals("[153, 370, 371, 407]", Arrays.toString(Sumpowdig.eqSumPowDig(500, 3)));
	}
}