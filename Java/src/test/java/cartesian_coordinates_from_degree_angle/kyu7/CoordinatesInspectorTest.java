package cartesian_coordinates_from_degree_angle.kyu7;

import org.junit.Test;

import java.awt.geom.Point2D;

import static org.junit.Assert.assertEquals;

public class CoordinatesInspectorTest {
	@Test
	public void test_1() {
		Point2D result = new CoordinatesInspector().coordinates(90.0,1.0);
		assertEquals("Incorrect coordinates", new Point2D.Double(0.0,1.0), result);
	}
}