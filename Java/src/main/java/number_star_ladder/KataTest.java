package number_star_ladder;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

	String a1 = "1\n1*2\n1**3";
	String a2 = "1\n1*2\n1**3\n1***4\n1****5\n1*****6\n1******7";
	String a3 = "1\n1*2\n1**3\n1***4\n1****5\n1*****6\n1******7\n1*******8\n1********9\n1*********10\n1**********11\n1***********12\n1************13\n1*************14\n1**************15\n1***************16\n1****************17\n1*****************18\n1******************19\n1*******************20";

	@Test
	void basicTest(){
		assertEquals("1", Kata.pattern(1), "For input \"1\"");
		assertEquals("1\n1*2", Kata.pattern(2), "For input \"2\"");
		assertEquals(a1, Kata.pattern(3), "For input \"3\"");
		assertEquals(a2, Kata.pattern(7), "For input \"7\"");
		assertEquals(a3, Kata.pattern(20), "For input \"20\"");
	}
}
