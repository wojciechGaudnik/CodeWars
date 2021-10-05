package last_survivors_ep_2.kyu6;

import org.junit.jupiter.api.MethodOrderer;
import org.junit.jupiter.api.Order;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.TestMethodOrder;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

@TestMethodOrder(MethodOrderer.OrderAnnotation.class)
public class KataTest {
	@Test
	@Order(1)
	void ordinary() {
		assertEquals("ac", sort(Kata.lastSurvivors("abaa")), String.format("given: %s", "abaa"));
		assertEquals("c", sort(Kata.lastSurvivors("zzab")), String.format("given: %s", "zzab"));
		assertEquals("", sort(Kata.lastSurvivors("")), String.format("given: %s", ""));
	}

	@Test
	@Order(2)
	void zeroLength() {
		assertEquals("", sort(Kata.lastSurvivors("")), String.format("given: %s", ""));
	}

	@Test
	@Order(3)
	void newEdge() {
		String str ="xsdlafqpcmjytoikojsecamgdkehrqqgfknlhoudqygkbxftivfbpxhxtqgpkvsrfflpgrlhkbfnyftwkdebwfidmpauoteahyh";
		assertEquals("acdeghlmnqrvyz", sort(Kata.lastSurvivors(str)), String.format("given: %s", str));
	}

	static private String sort(String s) {
		char[] chars = s.toCharArray();
		Arrays.sort(chars);
		return new String(chars);
	}
}