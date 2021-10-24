package decimal_to_factorial_and_back.kyu5;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class Dec2FactTest {
	@Test
	public void test11() {
		assertEquals(Dec2Fact.dec2FactString(1001L), "1212210");
	}

//	@Test
//	public void test12() {
//		assertEquals(Dec2Fact.factString2Dec("2DCAA5842344512200"),1000000000000000L );
//	}


	@Test
	public void test13() {
		assertEquals(Dec2Fact.factString2Dec("17747074033000"),9876543210L);
	}
}