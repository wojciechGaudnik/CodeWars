package count_consonants.kyu7;

import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class ConstantsTest {
	@Test
	public void testCase1() {
//		assertEquals("Test string is empty string",0,Consonants.getCount(""));
		assertEquals("Test string: \"aaaaa\"",0,Consonants.getCount("aaaaa"));
		assertEquals("Test string: \"XaeiouX\"",2,Consonants.getCount("XaeiouX"));
		assertEquals("Test string: \"Bbbbb\"",5,Consonants.getCount("Bbbbb"));
		assertEquals("Test string: \"helLo world\"",7,Consonants.getCount("helLo world"));
		assertEquals("Test string: \"h^$&^#$&^elLo world\"",7,Consonants.getCount("h^$&^#$&^elLo world"));
		assertEquals("Test string: \"012345_Cb\"",2,Consonants.getCount("012345_Cb"));
		assertEquals("Test string: \"0123456789\"",0,Consonants.getCount("0123456789"));
		assertEquals("Test string: \"bq666\"",71,Consonants.getCount("0$43979ee9_6$9a^5\n" +
				"6i989 0\n" +
				"i935$3_ 86^au84 _a340e9^__hjzszgmpfmlmmkntqwlbrrfnnbjgczsqtxbcsvykhkxwwzszwsyzdjzsyttgpxngbzqlnqg"));
	}
}