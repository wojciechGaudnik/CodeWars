package Leetspeak;

import org.junit.Test;

import static org.junit.Assert.*;

public class EncodeSimpleTest {

	Leetspeak myEncoder = new Leetspeak();

	@Test
	public void simpleTest(){
		assertEquals("empty string", "", myEncoder.encode(""));
		assertEquals("abcdef string", "4bcd3f", myEncoder.encode("abcdef"));
	}
}