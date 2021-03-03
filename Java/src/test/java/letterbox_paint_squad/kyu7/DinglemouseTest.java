package letterbox_paint_squad.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class DinglemouseTest {
	@Test
	public void ex() {
		assertArrayEquals(new int[]{1,9,6,3,0,1,1,1,1,1}, Dinglemouse.paintLetterboxes(125,132));
	}
}