package _80_s_kids_5_you_can_t_do_that_on_television.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class EightiesKids5Test {

	@Test
	public void test1() {
		assertEquals("water", EightiesKids5.bucketOf("water"));
	}

	@Test
	public void test2() {
		assertEquals("slime", EightiesKids5.bucketOf("slime"));
	}

	@Test
	public void test3() {
		assertEquals("sludge", EightiesKids5.bucketOf("Will I get wet? I don't know."));
	}

	@Test
	public void test4() {
		assertEquals("air", EightiesKids5.bucketOf("This should be safe."));
	}
}