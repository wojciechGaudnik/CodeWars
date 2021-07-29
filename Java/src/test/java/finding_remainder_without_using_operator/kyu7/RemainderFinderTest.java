package finding_remainder_without_using_operator.kyu7;

import org.junit.Test;
import static org.junit.Assert.assertEquals;


public class RemainderFinderTest {
	@Test
	public void test1() {
		assertEquals(new SimpleInteger(1), RemainderFinder.remainder(new SimpleInteger(19), new SimpleInteger(2)));
	}

	@Test
	public void test2() {
		assertEquals(new SimpleInteger(0), RemainderFinder.remainder(new SimpleInteger(10), new SimpleInteger(2)));
	}

	@Test
	public void test3() {
		assertEquals(new SimpleInteger(6), RemainderFinder.remainder(new SimpleInteger(34), new SimpleInteger(7)));
	}

	@Test
	public void test4() {
		assertEquals(new SimpleInteger(2), RemainderFinder.remainder(new SimpleInteger(27), new SimpleInteger(5)));
	}
}