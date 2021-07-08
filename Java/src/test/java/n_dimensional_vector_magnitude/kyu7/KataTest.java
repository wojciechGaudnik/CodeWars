package n_dimensional_vector_magnitude.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void zeroVector() {
		double[] vector = new double[] { 0d, 0d };
		assertEquals(0d, Kata.magnitude(vector), 1e-10);
	}

	@Test
	public void unitVector() {
		double[] vector = new double[] { 2d / 3d, 1d / 3d, 2d / 3d };
		assertEquals(1d, Kata.magnitude(vector), 1e-10);
	}

	@Test
	public void negativeValues() {
		double[] vector = new double[] { -2d, -4d, 4d };
		assertEquals(6d, Kata.magnitude(vector), 1e-10);
	}
}