package responsible_drinking.kyu7;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

class DringkinTest {


	@Test
	public void drinkinTest1() {
		Drinkin drinkin = new Drinkin();
		String expected = "1 glass of water";
		String actual = drinkin.hydrate("1 beer");
		Assert.assertEquals(expected, actual);
	}

	@Test
	public void drinkinTest3() {
		Drinkin drinkin = new Drinkin();
		String expected = "10 glasses of water";
		String actual = drinkin.hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
		Assert.assertEquals(expected, actual);
	}

}