package monty_hall_problem.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class MontyHallTest {
	MontyHall montyHall = new MontyHall();

	@Test
	public void test() {
		assertEquals(71, montyHall.montyHallCase(1, new int[]{3, 3, 2, 3, 3, 2, 2, 3, 2, 2, 1, 1, 1, 1}));
		assertEquals(64, montyHall.montyHallCase(2, new int[]{3, 3, 2, 3, 3, 2, 2, 3, 2, 2, 1, 1, 1, 1}));
		assertEquals(64, montyHall.montyHallCase(3, new int[]{3, 3, 2, 3, 3, 2, 2, 3, 2, 2, 1, 1, 1, 1}));
	}
}