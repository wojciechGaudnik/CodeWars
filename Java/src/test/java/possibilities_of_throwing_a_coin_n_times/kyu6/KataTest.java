package possibilities_of_throwing_a_coin_n_times.kyu6;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;
public class KataTest {
	@Test
	public void BasicTests() throws Exception {
		Kata c = new Kata();

		assertEquals(new Object[] {"H","T"}, (Object[])c.coin(1));
		assertEquals(new Object[] {"HH","HT","TH","TT"}, (Object[])c.coin(2));
		assertEquals(new Object[] {"HHH","HHT","HTH","HTT","THH","THT","TTH","TTT"}, (Object[])c.coin(3));
	}
}