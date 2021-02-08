package Silly_16_18_214.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SillyAdditonTest {
	@Test
	public void RealAddition() {
		System.out.println("****** Real addition ******");
		assertEquals(13, SillyAdditon.add(2,11));
		assertEquals(1, SillyAdditon.add(0,1));
		assertEquals(0, SillyAdditon.add(0,0));
	}


	@Test
	public void SillyAdditon() {
		System.out.println("****** Silly addition******");
		assertEquals(214, SillyAdditon.add(16,18));
		assertEquals(515, SillyAdditon.add(26,39));
		assertEquals(1103, SillyAdditon.add(122,81));
	}
}