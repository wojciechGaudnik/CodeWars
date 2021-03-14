package complete_the_pattern_4.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class PatternTest {
	@Test
	public void pattern() throws Exception {
		assertEquals( Pattern.pattern( 1 ), "1" );
		assertEquals( Pattern.pattern( 2 ), "12\n2" );
		assertEquals( Pattern.pattern( 5 ), "12345\n2345\n345\n45\n5" );
		assertEquals( Pattern.pattern( 0 ), "" );
		assertEquals( Pattern.pattern( -25 ), "" );
		assertEquals( Pattern.pattern( -59 ), "" );
	}
}