package converting_from_base_10_to_16_dare_you.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class HexadecimalTest {

	@Test
	public void test (){
		assertEquals("0x100",Hexadecimal.convertToHex(256));
	}

}