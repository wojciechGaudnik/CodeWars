package grill_it.kyu6;


import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class GrillItTest {
	@Test
	public void basicGrille() {
		assertEquals("df", GrillIt.grille("abcdef", 5));
		assertEquals("", GrillIt.grille("", 5 ));
		assertEquals("d", GrillIt.grille("abcd",1 ));
		assertEquals("b", GrillIt.grille("0abd", 2));
		assertEquals("codewars", GrillIt.grille("tcddoadepwweasresd", 77098));
	}
}



