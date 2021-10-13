package weird_ipv6_hex_string_parsing.kyu6;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests() {
		assertEquals("10264228481217", Solution.parseIPv6("1234:5678:9ABC:D00F:1111:2222:3333:4445"));
		assertEquals("18544240608532", Solution.parseIPv6("5454:FBFD:9ABC:AAAA:FFFF:2222:FBDE:0101"));
		assertEquals("00000000", Solution.parseIPv6("0000:0000:0000:0000:0000:0000:0000:0000"));
		assertEquals("6060444864304", Solution.parseIPv6("FFFF:FFFF:BBBB:CCCC:1212:AABC:0000:1111"));
		assertEquals("48242406085346", Solution.parseIPv6("ACDD-0101-9ABC-AAAA-FFFF-2222-FBDE-ACCC"));
		assertEquals("18544230558532", Solution.parseIPv6("5454rFBFDr9ABCrAA0ArFAFFr2222rFBDEr0101"));
		assertEquals("24264228481221", Solution.parseIPv6("F234#5678#9ABC#D00F#1111#2222#3333#4485"));
	}
}