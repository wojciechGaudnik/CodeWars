package delta_bits.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertThat;
import static org.hamcrest.CoreMatchers.is;
class DeltaBitsTest {

	@Test
	public void test() throws Exception {
		assertThat(DeltaBits.convertBits(31, 14), is(2));
	}
}