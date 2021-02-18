package Covfefe.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class CoveveTest {
	@Test
	public void basicTest() {
		assertEquals("covfefe", Covfefe.covfefe("coverage"));
		assertEquals("covfefe covfefe", Covfefe.covfefe("coverage coverage"));
		assertEquals("nothing covfefe", Covfefe.covfefe("nothing"));
		assertEquals( "double space  covfefe" ,Covfefe.covfefe("double space "));
		assertEquals("covfefe covfefe", Covfefe.covfefe("covfefe"));
	}
}