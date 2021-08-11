package geometry_basics_dot_product_in_3D.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

// TODO: Replace examples and use TDD development by writing your own tests

public class GeometryBasicsTest {
	@Test
	public void sampleTests() {
		doTest(new Vector3D(2, 0, -1), new Vector3D(0, -2, 1), -1);
		doTest(new Vector3D(1, 1, 1), new Vector3D(2, -2, 2), 2);
		doTest(new Vector3D(7, 2.5, -3), new Vector3D(0.4, -0.9, 0.2), -0.05);
	}

	public static void doTest(final Vector3D a, final Vector3D b, final double expected) {
		assertEquals(expected, GeometryBasics.dotProduct(a, b), 0.000001);
	}
}