package first_variation_on_caesar_cipher.kyu5;

import static org.junit.Assert.*;
import org.junit.Test;
import java.util.*;

public class CaesarCipherTest {

	@Test
	public void test1() {
		String u = "I should have known that you would have a perfect answer for me!!!";
		List<String> v = Arrays.asList(
				"J vltasl rlhr ",
				"zdfog odxr ypw",
				" atasl rlhr p ",
				"gwkzzyq zntyhv",
				" lvz wp!!!");
		assertEquals(v, CaesarCipher.movingShift(u, 1));
		assertEquals(u, CaesarCipher.demovingShift(CaesarCipher.movingShift(u, 1), 1));
	}
}