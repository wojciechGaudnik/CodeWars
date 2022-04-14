package vasya_and_system_of_equations.ky6;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SystemTests {

	@Test
	public void test1() {
		assertEquals(1, SystemOfEq.Solution(9, 3));
	}


	@Test
	public void test2() {
		assertEquals(1, SystemOfEq.Solution(14, 28));
	}

	@Test
	public void test3() {
		assertEquals(0, SystemOfEq.Solution(4, 20));
	}
}