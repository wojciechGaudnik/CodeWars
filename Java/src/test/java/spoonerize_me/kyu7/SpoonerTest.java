package spoonerize_me.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SpoonerTest {
	@Test
	public void basicTests() {
		Spooner spooner = new Spooner();
		assertEquals("pit nicking", spooner.spoonerize("nit picking"));
		assertEquals("bedding wells", spooner.spoonerize("wedding bells"));
		assertEquals("belly jeans", spooner.spoonerize("jelly beans"));
	}
}