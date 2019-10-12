package Twisted_3_7;

import static org.junit.Assert.*;

import org.junit.Test;
import static org.junit.Assert.assertEquals;
import org.junit.runners.JUnit4;
import java.util.Arrays;

public class KataTests {
	@Test
	public void basicTests() {
		assertEquals(Arrays.toString(new Integer[] {1,2,7,4,5,6,3,8,9}), Arrays.toString(Kata.sortTwisted37(new Integer[] {1,2,3,4,5,6,7,8,9})));
		assertEquals(Arrays.toString(new Integer[] {12,14,13}), Arrays.toString(Kata.sortTwisted37(new Integer[] {12,13,14})));
		assertEquals(Arrays.toString(new Integer[] {2,7,4,3,9}), Arrays.toString(Kata.sortTwisted37(new Integer[] {9,2,4,7,3})));
	}
}