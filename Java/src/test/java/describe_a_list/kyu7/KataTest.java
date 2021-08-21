package describe_a_list.kyu7;

import org.junit.Test;

import java.util.Arrays;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void examples() {
		// assertEquals("expected", "actual");
		assertEquals("empty", Kata.describeList(Arrays.asList(new Object[0])));
		assertEquals("empty", Kata.describeList(Arrays.asList(new Object[0])));
	}

	@Test
	public void examples1() {
		// assertEquals("expected", "actual");
		assertEquals("longer", Kata.describeList(Arrays.asList(1, 2)));
		assertEquals("longer", Kata.describeList(Arrays.asList(1.5, 2.5)));
	}

	@Test
	public void examples2() {
		// assertEquals("expected", "actual");
		assertEquals("singleton", Kata.describeList(Arrays.asList(1.5)));
		assertEquals("singleton", Kata.describeList(Arrays.asList(1)));
	}
}