package what_is_the_flag.kyu7;

import org.junit.jupiter.api.Test;

import java.security.MessageDigest;

import static java.nio.charset.StandardCharsets.UTF_8;
import static org.junit.jupiter.api.Assertions.assertTrue;

// TODO: Replace examples and use TDD by writing your own tests

class SolutionTest {
	@Test
	void theOnlyTest() throws Exception {
		assertTrue(isFlag(Kata.flag), "That's not the flag");
	}

	private boolean isFlag(String input) throws Exception {
		return "54eee94fc5d5f2f0a9e3ff9d48458e6d".equals(digest(input));
	}

	private String digest(String input) throws Exception {
		var md5 = MessageDigest.getInstance("MD5");
		byte[] digest = md5.digest(input.getBytes(UTF_8));
		StringBuilder sb = new StringBuilder(digest.length * 2);
		for (byte b : digest) sb.append(String.format("%02x", b));
		return sb.toString();
	}

}