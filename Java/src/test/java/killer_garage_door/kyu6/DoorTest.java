package killer_garage_door.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class DoorTest {
	@Test
	public void testNormalOperation() {
		test("should stay closed unless button is pressed (no buttonpresses)", "..........", "0000000000");
		test("should start opening on buttonpress", "P..", "123");
		test("should open completely and stay open", "P....", "12345");
	}

	@Test
	public void testPause() {
		test("should start opening and pause on second buttonpress", "P.P..", "12222");
	}

	@Test
	public void testObstacles() {
		test("should reverse while opening", "P.O....", "1210000");
	}

	@Test
	public void testExample() {
		test("should start opening and reverse when obstacle", "..P...O.....", "001234321000");
	}


	@Test
	public void testExample2() {
		test("should start opening and reverse when obstacle", ".....P......P.P..P....", "0000012345554333321000");
	}

	private void test(String description,String events,String result) {
		assertEquals(description,result,Door.run(events));
	}
}