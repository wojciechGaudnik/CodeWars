package fire_and_fury.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class DinglemouseTest {
	@Test
	public void ex1() {
		assertEquals("I am furious. You and you are fired!", Dinglemouse.fireAndFury("FURYYYFIREYYFIRE"));
	}

	@Test
	public void ex2() {
		assertEquals("You are fired! I am really furious. You are fired!", Dinglemouse.fireAndFury("FIREYYFURYYFURYYFURRYFIRE"));
	}

	@Test
	public void ex3() {
		assertEquals("Fake tweet.", Dinglemouse.fireAndFury("FYRYFIRUFIRUFURE"));
	}

	@Test
	public void ex4() {
		assertEquals("You are fired! I am really really furious. You and you are fired!", Dinglemouse.fireAndFury("FIREFURYIURYIIREUURYIURYRIREUIRERURYFURYRIREFURYRIREFIREEURYFIREUIRERURYYIREUURY"));
	}
}