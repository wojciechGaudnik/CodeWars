package simple_beads_count.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class BeadsCounterTest {
	@Test
	public void test0() {
		assertEquals(0, BeadsCounter.countRedBeads(0));
	}
	@Test
	public void test1() {
		assertEquals(0, BeadsCounter.countRedBeads(1));
	}
	@Test
	public void test3() {
		assertEquals(4, BeadsCounter.countRedBeads(3));
	}
	@Test
	public void test5() {
		assertEquals(8, BeadsCounter.countRedBeads(5));
	}
}