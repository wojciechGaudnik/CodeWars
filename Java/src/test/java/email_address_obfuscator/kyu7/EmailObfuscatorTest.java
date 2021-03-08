package email_address_obfuscator.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class EmailObfuscatorTest {
	@Test
	public void test1() {
		assertEquals("test [at] 123 [dot] com",
				EmailObfuscator.obfuscate("test@123.com"));
	}
	@Test
	public void test2() {
		assertEquals("Code_warrior [at] foo [dot] ac [dot] uk",
				EmailObfuscator.obfuscate("Code_warrior@foo.ac.uk"));
	}
}