package steps_in_k_primes.kyu6;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.assertEquals;

public class KprimesStepsTest {
	private static String listArrayLongToString(List<long[]> res) {
		String s = "["; int l = res.size();
		for (int i = 0; i < l; i++) {
			long[] a = res.get(i);
			s += "[" + a[0] + ", " + a[1];
			if (i < l-1) s += "], ";
			else s += "]";
		}
		return s += "]";
	}
	private static void testing(int k, int step, long start, long nd, String expected) {
		List<long[]> a = KprimesSteps.kprimesStep(k, step, start, nd);
		String actual = listArrayLongToString(a);
		System.out.println("k " + k + " step " + step + " start " + start + " end " + nd);
		//System.out.println("got --> " + actual);
		assertEquals(expected, actual);
	}
	@Test
	public void test() {
		System.out.println("Basic Tests");
		testing(10, 8, 2425364, 2425700, "[]");
		testing(6, 8, 2627371, 2627581, "[[2627408, 2627416], [2627440, 2627448], [2627496, 2627504]]");

	}
}