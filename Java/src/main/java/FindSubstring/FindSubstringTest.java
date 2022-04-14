package FindSubstring;

import org.junit.Test;

import static org.junit.Assert.*;

public class FindSubstringTest {
	@Test
	public void test() {
		assertEquals("Example test 1", 8, FindSubstring.longestSubstring("preface", "singularity"));
		assertEquals("Example test 2", 5, FindSubstring.longestSubstring(" 8684Hh", "7575H--8---"));
		assertEquals("Example test 3", 3, FindSubstring.longestSubstring("looking", "zoology"));
		assertEquals("Example test 4", 5, FindSubstring.longestSubstring("piquancy", "refocusing"));
		assertEquals("Example test 5", 3, FindSubstring.longestSubstring("cXWjf+Z8bd=+{{)NfWe6}l(`73U/*+T9+hN/?0=8=Sea*6Sgi&hlO6aP+j4hX`k6)(&%7`MjhYN/Q0T", "kkM&(TQQ fh1)^1 `kY/`=S1RU e<bcM(a}e<&fWQZ/Yh&j?{&/a&a} >/9W541*(=O3aMQ6cT*4ce98df^MP"));
		assertEquals("Example test 6", 2, FindSubstring.longestSubstring("<jQ/+Y=}5=/V>(RhXbgb7>i^>V)SZaP8?X/h/*<OV^Vd)dS6R0OS0 Q{YW6R/U/f", "4bYZSNVWWR8Xk^bc&5YSc }j){lh%3 dN<iQ 8l d g802>fOlaagbM(6`6128/g??3i&=Z*7*1"));

	}
}