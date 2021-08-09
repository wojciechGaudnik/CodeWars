package string_prefix_and_suffix.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SuffPrefTest {
	@Test
	public void basicTests(){
//		assertEquals(0,SuffPref.solve("abcd"));
		assertEquals(1,SuffPref.solve("abcda"));
		assertEquals(3,SuffPref.solve("abcdabc"));
		assertEquals(3,SuffPref.solve("abcabc"));
		assertEquals(1,SuffPref.solve("abcabca"));
		assertEquals(0,SuffPref.solve("abcdabcc"));
		assertEquals(2,SuffPref.solve("aaaaa"));
		assertEquals(2,SuffPref.solve("aaaa"));
		assertEquals(1,SuffPref.solve("aaa"));
		assertEquals(1,SuffPref.solve("aa"));
		assertEquals(0,SuffPref.solve("a"));
		assertEquals(0,SuffPref.solve("acbacc"));
	}
}