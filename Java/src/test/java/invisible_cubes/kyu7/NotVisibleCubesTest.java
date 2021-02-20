package invisible_cubes.kyu7;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class NotVisibleCubesTest {
	@Test
	public void fixedTest() {
		NotVisibleCubes kata = new NotVisibleCubes();
		Assertions.assertEquals(kata.notVisibleCubes(3L), Long.valueOf(1L), "should work for 3");
		Assertions.assertEquals(kata.notVisibleCubes(5L), Long.valueOf(27L), "should work for 5");
	}

}