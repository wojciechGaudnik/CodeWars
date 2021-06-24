package cat_years_dog_years_2.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;

public class DinglemouseTest {
	@Test
	public void one() {
		assertArrayEquals(new int[]{1,1}, Dinglemouse.ownedCatAndDog(15,15));
	}

	@Test
	public void two() {
		assertArrayEquals(new int[]{2,2}, Dinglemouse.ownedCatAndDog(24,24));
	}

	@Test
	public void ten() {
		assertArrayEquals(new int[]{10,10}, Dinglemouse.ownedCatAndDog(56,64));
	}

	@Test
	public void ten1() {
		assertArrayEquals(new int[]{18,10}, Dinglemouse.ownedCatAndDog(91,64));
	}

}